using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;

namespace traingapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProgramController : ControllerBase
    {
        private readonly TrainingDB _context;

        public TrainingProgramController(TrainingDB context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var trainingPrograms = _context.TrainingPrograms
                    .Include(tp => tp.TrainingDays)
                    .ThenInclude(td => td.TrainingDayExercises)
                    .ToList();
                return Ok(trainingPrograms);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var trainingProgram = _context.TrainingPrograms
                    .Include(tp => tp.TrainingDays)
                    .ThenInclude(td => td.TrainingDayExercises)
                    .FirstOrDefault(tp => tp.Id == id);

                if (trainingProgram == null)
                {
                    return NotFound("Training program not found.");
                }

                return Ok(trainingProgram);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateTrainingProgram([FromBody] TrainingProgram trainingProgram)
        {
            try
            {
                
                _context.TrainingPrograms.Add(trainingProgram);
                _context.SaveChanges();
                return CreatedAtAction("Get", new { id = trainingProgram.Id }, trainingProgram);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addTrainingDay/{trainingProgramId}")]
        public IActionResult AddTrainingDay(int trainingProgramId, [FromBody] TrainingDay trainingDay)
        {
            try
            {
                var trainingProgram = _context.TrainingPrograms
                    .Include(tp => tp.TrainingDays)
                    .FirstOrDefault(tp => tp.Id == trainingProgramId);

                if (trainingProgram == null)
                {
                    return NotFound("Training program not found.");
                }

                trainingProgram.TrainingDays.Add(trainingDay);
                _context.SaveChanges();

                return CreatedAtAction("Get", new { id = trainingDay.Id }, trainingDay);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addExercise/{trainingDayId}")]
        public IActionResult AddExercise(int trainingDayId, [FromBody] TrainingDayExercise trainingDayExercise)
        {
            try
            {
                var trainingDay = _context.TrainingDays
                    .Include(td => td.TrainingDayExercises)
                    .FirstOrDefault(td => td.Id == trainingDayId);

                if (trainingDay == null)
                {
                    return NotFound("Training day not found.");
                }

                trainingDay.TrainingDayExercises.Add(trainingDayExercise);
                _context.SaveChanges();

                return CreatedAtAction("Get", new { id = trainingDayExercise.Id }, trainingDayExercise);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
