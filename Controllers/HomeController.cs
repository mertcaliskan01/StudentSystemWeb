using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentSystemWeb.Helper;
using StudentSystemWeb.Models;


namespace StudentSystemWeb.Controllers
{
    public class HomeController : Controller
    {

        #region List/Index Section
        public async Task<IActionResult> Index()
        {
            using (StudentAPI _api = new StudentAPI())
            {
                List<StudentData> students = new List<StudentData>();
                HttpClient client = _api.Initial();
                HttpResponseMessage res = await client.GetAsync("api/student");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    students = JsonConvert.DeserializeObject<List<StudentData>>(results);
                }
                return View(students);
            }
        }
        #endregion

        #region Detail Section
        public async Task<IActionResult> Details(int id)
        {
            using (StudentAPI _api = new StudentAPI())
            {
                StudentData student = new StudentData();
                HttpClient client = _api.Initial();
                HttpResponseMessage res = await client.GetAsync($"api/student/{id}");
                if (res.IsSuccessStatusCode)
                {
                    var results = res.Content.ReadAsStringAsync().Result;
                    student = JsonConvert.DeserializeObject<StudentData>(results);
                }
                return View(student);
            }
        }

        #endregion

        #region Create Section

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentData studentData)
        {
            using (StudentAPI _api = new StudentAPI())
            {
                HttpClient client = _api.Initial();

                var postTask = client.PostAsJsonAsync<StudentData>("api/student", studentData);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
        }

        #endregion

        #region Edit Section

        public ActionResult Edit(int id)
        {
            using (StudentAPI _api = new StudentAPI())
            {
                StudentData student = null;
                HttpClient client = _api.Initial();

                //HTTP GET
                var res = client.GetAsync($"api/student/{id}");
                res.Wait();

                var result = res.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<StudentData>();
                    readTask.Wait();

                    student = readTask.Result;
                }
                return View(student);
            }
        }

        [HttpPost]
        public ActionResult Edit(StudentData student)
        {
            using (StudentAPI _api = new StudentAPI())
            {
                HttpClient client = _api.Initial();

                var putTask = client.PutAsJsonAsync<StudentData>($"/api/student/{student.Id}", student);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }

                return View(student);
            }
        }

        #endregion

        #region Delete Section

        public async Task<IActionResult> Delete(int Id)
        {
            using (StudentAPI _api = new StudentAPI())
            {
                var studentData = new StudentData();
                HttpClient client = _api.Initial();
                HttpResponseMessage res = await client.DeleteAsync($"api/student/{Id}");
                return RedirectToAction("Index");
            }
        }
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
