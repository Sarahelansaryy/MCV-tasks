function getapi() {
  fetch("https://jsonplaceholder.typicode.com/todos")
    .then((response) => response.json())
    .then((json) => {
      const sliced = json.slice(0, 6);
      console.log(sliced);

      let listHTML = `<ul class="list-group list-group-flush">`;
      sliced.forEach((item) => {
        listHTML += `<li id="todo-${item.id}" class="list-group-item d-flex justify-content-between align-items-center">
            <span class="todo-title">${item.title}</span>
        <div class="d-flex gap-2">
        <button class="btn btn-sm btn-danger" id="pending-${item.id}" onclick="changebackground(${item.id})">Pending</button>

        <button class="btn btn-sm btn-success" onclick="markDone(${item.id})">Done</button>
      </div>
    </li>
    </div>
    `;
      });
      listHTML += `</ul>`;

      document.getElementById("todolist").innerHTML = listHTML;
    })
    .catch((err) => console.error("Fetch error:", err));
}
function markDone(id) {
  const title = document.getElementById(`todo-${id}`);
  title.style.backgroundColor = "rgb(104, 206, 104)";
  title.style.textDecoration = "line-through";
  const pendingBtn = document.getElementById(`pending-${id}`);
  if (pendingBtn) {
    pendingBtn.style.display = "none";
  }
}
function changebackground(id) {
  const title = document.getElementById(`todo-${id}`);
  title.style.backgroundColor = "red";
}
