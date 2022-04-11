using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Consuming_WebAPI_using_MVC_Demo.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Consuming_WebAPI_using_MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        string BaseURL = "https://localhost:44353/";
        public async Task<ActionResult> Index()
        {
            List<Employee> EmpList = new List<Employee>();
            using(var client=new HttpClient())
            {
                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Employees");
                if(response.IsSuccessStatusCode)
                {
                    var EmployeeResponse = response.Content.ReadAsStringAsync().Result;
                    EmpList = JsonConvert.DeserializeObject<List<Employee>>(EmployeeResponse);
                }
                return View(EmpList);
            }
           // return View();
        }
        public async Task<ActionResult> GetEmployeeById(int id)
        {
            Employee Emp = new Employee();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync($"api/Employees/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var EmployeeResponse = response.Content.ReadAsStringAsync().Result;
                    Emp = JsonConvert.DeserializeObject<Employee>(EmployeeResponse);
                }
                return View(Emp);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            using(var client=new HttpClient())
            {
                client.BaseAddress =new Uri("https://localhost:44353/api/Employees");
                var postTask = client.PostAsJsonAsync<Employee>("Employees", employee);
                postTask.Wait();
                var result = postTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "server Error. pls try after sometime");
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            Employee emp=null;
            using(var client=new HttpClient())
            {
                client.BaseAddress= new Uri("https://localhost:44353/api/");
                var responsetask = client.GetAsync("Employees?id=" + id.ToString());
                responsetask.Wait();
                var result = responsetask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsAsync<Employee>();
                    readtask.Wait();
                    emp = readtask.Result;

                }
            }

            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://localhost:44353/api/");
                var putTask = client.PutAsJsonAsync<Employee>($"Employees/{employee.ID}", employee);
                putTask.Wait();
                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "server Error. pls try after sometime");
            return View(employee);
        }
        public ActionResult Delete(int id)
        {
          
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44353/api/");
                var deletetask = client.DeleteAsync("Employees?id=" + id.ToString());
                deletetask.Wait();
                var result = deletetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }
            }

            return View();
        }
    }
}