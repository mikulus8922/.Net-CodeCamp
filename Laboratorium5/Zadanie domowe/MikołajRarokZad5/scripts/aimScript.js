// Referencje do obiektów strony
let statusDiv = document.querySelector('.status');
let resetDiv = document.querySelector('.reset');
let cellDivs = document.querySelectorAll('.game-cell');

// Czas trwania gry
let gameTime = 15;

// Licznik trafionych celów
var counter = 0;

// Zmienna przechowywująca czas rozpoczęcia gry
var startTime;

// Numer komórki porzednio wybranej
// jako cel
var lastGeneratedNumber = 1000;

let gameIsLive = false;

// Funkcja losująca nowy cel
function generateNextTarget() {
    let randomNumber = Math.floor(Math.random() * cellDivs.length);

    while (randomNumber == lastGeneratedNumber)
        randomNumber = Math.floor(Math.random() * cellDivs.length);

    lastGeneratedNumber = randomNumber;

    cellDivs[randomNumber].classList.add('x');

}

// Funkcja sprawdzająca czy minął czas gry
function checkTime() {
    if ((Date.now() - startTime) > (gameTime * 1000))
        gameIsLive = false;
    if (gameIsLive == false) {
        alert("Your score is " + counter + "!");
        for (let cellDiv of cellDivs) {
            cellDiv.classList.remove('x');
        }
    }
        
}



// Funkcja rozpoczynająca/resetująca rozgrywkę
function handleReset() {
    counter = 0;
    statusDiv.innerHTML = `${counter}`;

    startTime = Date.now();

    gameIsLive = true;


    for (let cellDiv of cellDivs) {
        cellDiv.classList.remove('x');
    }

    generateNextTarget();

    
}

// Funkcja obsługująca kliknięcie na komórkę
function handleCellClick(e) {
    let classList = e.target.classList;

    checkTime();

    if (!gameIsLive)
        return;

    if (classList[1] !== 'x') {
        counter--;
    }

    if (classList[1] === 'x') {
        classList.remove('x');
        generateNextTarget();
        counter++;
    }

    statusDiv.innerHTML = `${counter}`;

}

// dodanie eventListenerów
resetDiv.addEventListener('click', handleReset);

for (let cellDiv of cellDivs) {
    cellDiv.addEventListener('click', handleCellClick);
}