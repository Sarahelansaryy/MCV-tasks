let btn = document.getElementById("launch");
btn.addEventListener("click", launching);

btn.addEventListener("mouseover", function () {
  btn.style.backgroundColor = "green";
});

btn.addEventListener("mouseout", function () {
  btn.style.backgroundColor = "";
});
let rocket = document.getElementById("rocket");
function launching() {
  rocket.style.animation = "launchanimation 2s ease-in-out ";
}
