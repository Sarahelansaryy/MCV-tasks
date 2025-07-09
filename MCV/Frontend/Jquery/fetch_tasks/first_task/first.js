let element = document
  .getElementById("btn")
  .addEventListener("click", fortuneGen);
let p = document.getElementById("p");
let fortunes = ["Fortune 1", "Fortune2", "Fortune3", "Fortune4", "Fortune5"];
function fortuneGen() {
  p.innerHTML = "Generating fortune...";
  let myPromise = new Promise(function (resolve, reject) {
    setTimeout(() => {
      let index = Math.floor(Math.random() * fortunes.length);
      resolve(fortunes[index]);
    }, 3000);
  });

  myPromise
    .then(function (result) {
      p.innerHTML = result;
      setTimeout(() => {
        p.hidden = true;
      }, 1000);
    })

    .catch(function (error) {
      p.innerHTML = "Error";
    });
}
