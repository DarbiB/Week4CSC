using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainApi : ControllerBase
    {

        [HttpPost(Name = "GetWeatherForecast")]
        public ActionResult<List<string>> IntListWork(List<int> lint)
        {
            
                List<string> slist = new List<string>();
                double sum = 0;
                double counter = 0;
                double avg = 0;
                double sumOfSquares = 0;
                double standardDev = 0;
                double varianceValue = 0;


                try { 
                lint.Sort();

                foreach (int i in lint)
                {
                    counter++;
                    if (counter > 1)
                    {

                        sum += i;
                        avg = sum / counter;
                        sumOfSquares += Math.Pow((i - avg), 2.0);
                        varianceValue = sumOfSquares / (counter - 1);
                        standardDev = Math.Sqrt(varianceValue);
                    }


                    if (counter > 1)
                    {

                        slist.Add("Elements: " + counter + ": Current Standard Deviation: " + standardDev);
                    }
                    else
                    {
                        slist.Add("List too small");
                    }


                }

                
            }
            
            catch(Exception)
            {
                Console.WriteLine("Bad data entered");
            }
            return slist;

        }
    }
}