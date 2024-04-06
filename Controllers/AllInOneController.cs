using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniCh5_7EndPoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllInOneController : ControllerBase
    {
        [HttpGet("/Tale")]
        public string Tale(string name, string time, string work, string city, string state)
        {
            string story = " Hello my name is " + name + " and i work at " + work + " I get there at " + time + " and i live in " + city + " " + state;

            return $"{story}";

        }


        [HttpGet("/EoO")]
        public string OddEven(string number)
        {
            int isNumber = 0;
            bool isValid = Int32.TryParse(number, out isNumber);
            string result = $"{isNumber} is odd";
            if (!isValid)
            {
                result = "Invalid Entry";
            }
            else if (isNumber % 2 == 0)
            {
                result = $"{isNumber} is even";
            }
            return result;
        }

        [HttpGet]
         [Route("ReverseNum/{userInput}")]
        public string Reverse(string userInput)
        {
            int validNum = 0;
            bool canParse;
            string reversedOutput = "";

            canParse = Int32.TryParse(userInput, out validNum);
            if (canParse == false)
            {
                return "INVALID ENTRY! Please enter numbers!";
            }

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversedOutput = reversedOutput + userInput[i];
            }
            return reversedOutput;
        }

        [HttpGet]
        [Route("reverseIt/{userInput}")]
        public string reverse(string userInput){
           string reverse = "";
           bool word = true;
       
           if(word == false){
            return "Enter in a letter please";
           }

           for(int i = userInput.Length - 1; i >= 0; i--){
            reverse = reverse + userInput[i];
           }
            return reverse;
        }
    }
}