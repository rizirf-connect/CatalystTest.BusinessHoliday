using AutoMapper;
using CatalystTest.BusinessHoliday.Domain.Entities;
using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Web.Controllers
{
    [Authorize]
    public class HolidaysController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IHolidayRepository _holidayRepository;
        private readonly IMapper _mapper;

        public HolidaysController(
            IMediator mediator,
            IHolidayRepository holidayRepository,
            IMapper mapper)
        {
            _mediator = mediator
                ?? throw new ArgumentNullException(nameof(mediator));
            _holidayRepository = holidayRepository
                ?? throw new ArgumentNullException(nameof(holidayRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: Holidays
        public async Task<IActionResult> Index()
        {
            var holidays = await _holidayRepository.GetAll();
            return View(holidays);
        }

        // GET: Holidays/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _holidayRepository.GetById(id);
            if (holiday == null)
            {
                return NotFound();
            }

            return View(holiday);
        }

        // GET: Holidays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Holidays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HolidayOccasion,FromDate,ToDate,Active")] Holiday holiday)
        {
            if (ModelState.IsValid)
            {
                holiday.Id = Guid.NewGuid();
                await _holidayRepository.Add(holiday);
                return RedirectToAction(nameof(Index));
            }
            return View(holiday);
        }

        // GET: Holidays/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _holidayRepository.GetById(id);
            if (holiday == null)
            {
                return NotFound();
            }
            return View(holiday);
        }

        // POST: Holidays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,HolidayOccasion,FromDate,ToDate,Active")] Holiday holiday)
        {
            if (id != holiday.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _holidayRepository.Update(holiday);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HolidayExists(holiday.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(holiday);
        }

        // GET: Holidays/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _holidayRepository.GetById(id);
            if (holiday == null)
            {
                return NotFound();
            }

            return View(holiday);
        }

        // POST: Holidays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var holiday = await _holidayRepository.GetById(id);
            await _holidayRepository.Remove(holiday);
            return RedirectToAction(nameof(Index));
        }

        private bool HolidayExists(Guid id) =>
            _holidayRepository.HolidayExists(id);
    }
}
