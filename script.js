const catsName = document.getElementById("nameInput").value;
const button = document.getElementById("btn");

const checkSyllables = () => {
  for (i in catsName) {
    if (catsName.match(/ee|i|y/gi)) {
      document.getElementById("resultOutput").innerHTML =
        "<b>Perfect!</b><br>Your kitten's name is awesome, and he will lovingly respond to your calls.";
      return;
    } else if (catsName.match(/a|e/gi)) {
      document.getElementById("resultOutput").innerHTML =
        "<b>Good.</b><br>Your kitten's name is great, and he will attach to it easily.";
      return;
    } else {
      document.getElementById("resultOutput").innerHTML =
        "<b>Not so good .</b><br>Your kitten's name is lovely, but he may find it difficult to identify. But don't worry, you can keep the name and follow some of the tips below.";
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
