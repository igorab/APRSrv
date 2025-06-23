using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using APRSrv.Models;

namespace APRSrv.Services
{
    /// <summary>
    /// сервис для взаимодействия с API
    /// </summary>
    public class RobotTaskService
    {
        private readonly HttpClient _httpClient;

        public RobotTaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RobotTask>> GetRobotTasksAsync()
        {
            return new List<RobotTask> { new RobotTask() {TaskId = 1, TaskValue = 234, TaskName = "Go!" } }; 
            //return await _httpClient.GetFromJsonAsync<List<RobotTask>>("http://localhost:5143/api/RobotTask");
        }

        public async Task<RobotTask> CreateRobotTaskAsync(RobotTask robotTask)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5143/api/RobotTask", robotTask);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<RobotTask>();
        }
    }
}
