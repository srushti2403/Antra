//Que-1
let salaries = {
  John: 100,
  Ann: 160,
  Pete: 130
};

let sum = 0;

for (let key in salaries) {
  sum += salaries[key];
}

console.log(sum);

//Que-2
function multiplyNumeric(obj) {
  for (let key in obj) {
    if (typeof obj[key] === "number") {
      obj[key] *= 2;
    }
  }
}

let menu = {
  width: 200,
  height: 300,
  title: "My menu"
};

multiplyNumeric(menu);

console.log(menu);

//Que-3
function checkEmailId(str) {
  str = str.toLowerCase();

  let atPos = str.indexOf("@");
  let dotPos = str.lastIndexOf(".");

  // must contain both
  if (atPos === -1 || dotPos === -1) return false;

  // @ must come before .
  if (atPos > dotPos) return false;

  // must be at least 1 character between @ and .
  if (dotPos - atPos < 2) return false;

  return true;
}

console.log(checkEmailId("abc@test.com"));
console.log(checkEmailId("abc@testcom"));

//Que-4
function truncate(str, maxlength) {
  if (str.length > maxlength) {
    return str.slice(0, maxlength - 1) + "…";
  }
  return str;
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
// "What I'd like to te…"

console.log(truncate("Hi everyone!", 20));

//Que-5
let styles = ["James", "Brennie"];
console.log(styles.join(", "));

// Append "Robert"
styles.push("Robert");
console.log(styles.join(", "));

// Replace middle with "Calvin"
let middle = Math.floor((styles.length - 1) / 2);
styles[middle] = "Calvin";
console.log(styles.join(", "));

// Remove first value and show it
styles.shift();
console.log(styles.join(", "));

// Prepend "Rose" and "Regal"
styles.unshift("Rose", "Regal");
console.log(styles.join(", "));