const catsName = document.getElementById("nameInput").value;
const button = document.getElementById("btn");

const checkSyllables = () => {
  for (i in catsName) {
    if (catsName.match(/ee|i|y/gi)) {
      document.getElementById("resultOutput").innerHTML =
        "<b>Purrfect!</b><br>Your kitten's name is awesome and easily recognizable. For a better experience, remember to pronounce it with affection.";
      return;
    } else if (catsName.match(/a|e/gi)) {
      document.getElementById("resultOutput").innerHTML =
        "<b>Good!</b><br>Your kitten's name is great, and it is easy to recognize. Do not forget to reinforce the high-pitched syllables.";
      return;
    } else {
      document.getElementById("resultOutput").innerHTML =
        "<b>Not so good!</b><br>Your kitten's name is lovely, but it may be difficult to recognize. Don't worry, you should keep this name and follow some of the tips below.";
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
