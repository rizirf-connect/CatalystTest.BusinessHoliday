using AutoMapper;
using CatalystTest.BusinessHoliday.Domain;
using CatalystTest.BusinessHoliday.Domain.Commands;
using CatalystTest.BusinessHoliday.Domain.Entities;
using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using CatalystTest.BusinessHoliday.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HolidaysController(
            IMediator mediator,
            IHolidayRepository holidayRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator
                ?? throw new ArgumentNullException(nameof(mediator));
            _holidayRepository = holidayRepository
                ?? throw new ArgumentNullException(nameof(holidayRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor
                ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        // GET: Holidays/WorkingDays
        public IActionResult WorkingDays()
        {
            ViewData["WorkingDays"] = 0;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WorkingDays(CheckWorkingDaysViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewData["WorkingDays"] = await _holidayRepository.CalculateWorkingDays(model.StartDate, model.EndDate);
                return View();
            }

            ViewData["WorkingDays"] = 0;
            return View();
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
        public async Task<IActionResult> Create(CreateHolidayCommand request)
        {
            var result = await _mediator.Send(request);
            return Result(request, result);
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
            var command = _mapper.Map<UpdateHolidayCommand>(holiday);
            return View(command);
        }

        // POST: Holidays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateHolidayCommand request)
        {
            var result = await _mediator.Send(request);
            return Result(request, result);
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
            var request = new DeleteHolidayCommand(id);
            var result = await _mediator.Send(request);
            return Result(request, result);
        }

        private bool HolidayExists(Guid id) =>
            _holidayRepository.HolidayExists(id);

        private IActionResult Result(HolidayCommand request, Result result)
        {
            if (result.HasErrors)
            {
                result.Errors.ToList().ForEach(err => ModelState.AddModelError(string.Empty, err));
                return View(request);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
