using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {
        private static List<Todo> todos = new List<Todo>();
        private static int nextId = 1;

        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            return todos;
        }

        [HttpPost]
        public Todo Create([FromBody] Todo todo)
        {
            todo.Id = nextId++;
            todos.Add(todo);
            return todo;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            todos.Remove(todo);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Todo updatedTodo)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            todo.Task = updatedTodo.Task;
            todo.IsDone = updatedTodo.IsDone;
            return Ok(todo);
        }
    }
}
