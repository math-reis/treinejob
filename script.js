const catsName = document.getElementById("nameInput").value;
const button = document.getElementById("btn");

const checkSyllables = () => {
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

checkSyllables(catsName);

const keyUp = (e) => {
  e = e || window.event;
  if (e.keyCode == 13) {
    document.getElementById("btn").click();
    return false;
  }
  return true;
};
