using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using WebApplication1.DAL;
using WebApplication1.Models;
using DemoServiceReference;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private CalculatorSoapClient CalculatorSoapClient = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
        private TesdDemoDb _db;
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(TesdDemoDb db,ILogger<ValuesController> logger)
        {
            _db = db;
            _logger = logger;
        }
        #region AddMethod
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Number number)
        {
            _logger.LogInformation("start add method");
            int result = 0;
            if (ModelState.IsValid)
            {

                FirstTable first = null;
                try
                {
                    result =await CalculatorSoapClient.AddAsync(number.IntA,number.IntB);
                    _logger.LogInformation("result successful");
                    first = new FirstTable();
                    _db.firstTables.Add(first);
                    await _db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Request dont coreect",ex);
                    throw;
                }
                _db.secondTables.Add(new SecondTable(first.Id, result.ToString()));
                await _db.SaveChangesAsync();
                _logger.LogInformation("Successful");
                return Ok(result);
            }

            return BadRequest();
        }
        #endregion

        #region Divide
        [HttpPost("divide")]
        public async Task<IActionResult> Divide([FromBody] Number number)
        {
            _logger.LogInformation("start add method");
            int result = 0;
            if (ModelState.IsValid)
            {

                FirstTable first = null;
                try
                {
                    result = await CalculatorSoapClient.DivideAsync(number.IntA, number.IntB);
                    _logger.LogInformation("result successful");
                    first = new FirstTable();
                    _db.firstTables.Add(first);
                    await _db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Request dont coreect", ex);
                    throw;
                }
                _db.secondTables.Add(new SecondTable(first.Id, result.ToString()));
                await _db.SaveChangesAsync();
                _logger.LogInformation("Successful");
                return Ok(result);
            }

            return BadRequest();
        }
        #endregion

        #region Multiply
        [HttpPost("multiply")]
        public async Task<IActionResult> Multiply([FromBody] Number number)
        {
            _logger.LogInformation("start add method");
            int result = 0;
            if (ModelState.IsValid)
            {

                FirstTable first = null;
                try
                {
                    result = await CalculatorSoapClient.MultiplyAsync(number.IntA, number.IntB);
                    _logger.LogInformation("result successful");
                    first = new FirstTable();
                    _db.firstTables.Add(first);
                    await _db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Request dont coreect", ex);
                    throw;
                }
                _db.secondTables.Add(new SecondTable(first.Id, result.ToString()));
                await _db.SaveChangesAsync();
                _logger.LogInformation("Successful");
                return Ok(result);
            }

            return BadRequest();
        }
        #endregion

        #region Subtract
        [HttpPost("substract")]
        public async Task<IActionResult> Subtrac([FromBody] Number number)
        {
            _logger.LogInformation("start add method");
            int result = 0;
            if (ModelState.IsValid)
            {

                FirstTable first = null;
                try
                {
                    result = await CalculatorSoapClient.SubtractAsync(number.IntA, number.IntB);
                    _logger.LogInformation("result successful");
                    first = new FirstTable();
                    _db.firstTables.Add(first);
                    await _db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("Request dont coreect", ex);
                    throw;
                }
                _db.secondTables.Add(new SecondTable(first.Id, result.ToString()));
                await _db.SaveChangesAsync();
                _logger.LogInformation("Successful");
                return Ok(result);
            }

            return BadRequest();
        }
        #endregion

    }
}
