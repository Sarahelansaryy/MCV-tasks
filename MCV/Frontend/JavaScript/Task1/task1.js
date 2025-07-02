let a = 5;
let b = 10;
console.log("**** task1 ****");
function swap(x, y) {
  let temp = x;
  x = y;
  y = temp;
  console.log("Inside function: a=" + x, "b=" + y);
}

swap(a, b);
console.log("Outside function: a=" + a, "b=" + b);

console.log("**** task2 ****");

let numbers = [4, 9, 2, 7, 5];
function Find_Max(n) {
  n.sort(function (a, b) {
    return a - b;
  });
  return n[n.length - 1];
}
console.log("max num is: " + Find_Max(numbers));

console.log("**** task3 ****");
function count_vowels(s) {
  let count = 0;
  for (let i = 0; i < s.length; i++) {
    if (
      s[i] == "a" ||
      s[i] == "o" ||
      s[i] == "e" ||
      s[i] == "u" ||
      s[i] == "i"
    ) {
      count++;
    }
  }
  return count;
}
console.log(
  " number of vowles in JavaScript is awesome is: " +
    count_vowels("JavaScript is awesome")
);
console.log("**** task4 ****");

function isPrime(n) {
  if (n <= 1) return false;
  for (let i = 2; i <= Math.sqrt(n); i++) {
    if (n % i === 0) return false;
  }
  return true;
}
console.log(isPrime(7));

console.log("**** task5 ****");
function String_Reverse(s) {
  let reversed = "";
  for (let i = s.length - 1; i >= 0; i--) {
    reversed += s[i];
  }
  return reversed;
}

console.log(String_Reverse("hello"));

console.log("**** task6 ****");
function Sum_Even(n) {
  let sum = 0;
  for (let i = 0; i < n.length; i++) {
    if (n % 2 == 0) {
      sum += n[i];
    }
  }
  return sum;
}
let nums = [1, 2, 3, 4, 5, 6];
console.log(Sum_Even(nums));
console.log("**** task7 ****");

function removeDuplicates(arr) {
  let result = [];
  for (let i = 0; i < arr.length; i++) {
    if (!result.includes(arr[i])) {
      result.push(arr[i]);
    }
  }
  return result;
}

let arr = [1, 2, 3, 2, 4, 1, 5];
console.log(removeDuplicates(arr));

console.log("**** task9 ****");

function factorial(n) {
  if (n === 0) return 1;
  return n * factorial(n - 1);
}

console.log(factorial(5));
console.log("**** task10 ****");
function obloop(c) {
  for (let key in c) {
    console.log(key + ": " + c[key]);
  }
}
let car = {
  brand: "Toyota",
  model: "Corolla",
  year: 2020,
  color: "blue",
};
console.log(obloop(car));
