let element = document
  .getElementById("btn")
  .addEventListener("click", fortuneGen);
let p = document.getElementById("p");
let fortunes = ["Fortune 1", "Fortune2", "Fortune3", "Fortune4", "Fortune5"];
function fortuneGen() {
  let index = Math.floor(Math.random() * fortunes.length);
  p.innerHTML = fortunes[index];
}
