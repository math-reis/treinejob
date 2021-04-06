const catsName = document.getElementById("nameInput").value;
const button = document.getElementById("btn");

const checkSill = () => {
  for (i in catsName) {
    if (catsName.match(/ee|i|y/gi)) {
      document.getElementById("resultOutput").innerHTML = "Perfect";
      return;
    } else if (catsName.match(/a|e/gi)) {
      document.getElementById("resultOutput").innerHTML = "Good";
      return;
    } else {
      document.getElementById("resultOutput").innerHTML = "Bad";
      return;
    }
  }
};

checkSill(catsName);
