using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calculatorController : ControllerBase
    {       
        
        // GET api/add
        [HttpGet("add")]
        public string Add([BindRequired] double op1, [BindRequired] double op2)
        {            
            double result = op1 + op2;
            string recordResult = $"{op1} + {op2} = {result}";
            //history = history + recordResult + "<br>";
            Record.AddRecord(recordResult);
            return recordResult;   
        }
        // GET api/minus
        [HttpGet("minus")]
        public string Minus([BindRequired] double op1, [BindRequired] double op2)
        {
            double result = op1 - op2;
            string recordResult = $"{op1} - {op2} = {result}";
            //history = history + recordResult + "<br>";
            //string txt = history;
            Record.AddRecord(recordResult);
            return recordResult;
        }
        // GET api/product
        [HttpGet("product")]
        public string Product([BindRequired] double op1, [BindRequired] double op2)
        {
            double result = op1 * op2;
            string recordResult = $"{op1} x {op2} = {result}";
            //history = history + recordResult + "<br>";
            Record.AddRecord(recordResult);
            return recordResult;
        }
        // GET api/divide
        [HttpGet("divide")]
        public string Divide([BindRequired] double op1, [BindRequired] double op2)
        {
            double result = op1 / op2;
            string recordResult = $"{op1} / {op2} = {result}";
            //history = history + recordResult + "<br>";
            Record.AddRecord(recordResult);
            return recordResult;
        }
        // GET api/history
        [HttpGet("history")]
        public string History()
        {
            //Record.ReadRecord();
            return Record.ReadRecord();
        }
        // GET api/clear
        [HttpGet("clear")]
        public string Clear()
        {                     
            return Record.DeleteRecord(); ;
        }


    }
}
