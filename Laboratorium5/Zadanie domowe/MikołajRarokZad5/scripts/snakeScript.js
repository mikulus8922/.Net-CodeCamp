window.onload = function initialize() {
    canv = document.getElementById("gc");
    ctx = canv.getContext("2d");
    document.addEventListener("keydown", keyPush);
    setInterval(game, 1000 / 15);
}


// pozycja głowy gracza
playerX = playerY = 10;
// rozmiar mapy
gridSize = tileCount = 20;
// pozycja jabłka
appleX = appleY = 15;
// kierunek ruchu węża
velocityX = velocityY = 0;
// tabela zawierająca współrzędne części węża
trail = [];
//długość węża
tail = 5;

// główna pętla gry
function game() {
    //zmień pozycję głowy
    playerX += velocityX;
    playerY += velocityY;

    /* funkcje if odpowiadające za teleportowanie
     * węża na drugą stronę mapy
     */
    if (playerX < 0) {
        playerX = tileCount - 1;
    }
    if (playerX > tileCount - 1) {
        playerX = 0;
    }
    if (playerY < 0) {
        playerY = tileCount - 1;
    }
    if (playerY > tileCount - 1) {
        playerY = 0;
    }

    // wyrysuj mapę
    ctx.fillStyle = "black";
    ctx.fillRect(0, 0, canv.width, canv.height);

    // wyrysuj węża
    ctx.fillStyle = "lime";
    for (var i = 0; i < trail.length; i++) {
        ctx.fillRect(trail[i].x * gridSize, trail[i].y * gridSize, gridSize - 2, gridSize - 2);
        if (trail[i].x == playerX && trail[i].y == playerY) {
            tail = 5;
        }
    }
    trail.push({ x: playerX, y: playerY });
    while (trail.length > tail) {
        trail.shift();
    }

    // część kodu wywoływany po zjedzeniu jabłka
    if (appleX == playerX && appleY == playerY) {
        tail++;

        /* generuj nowe współrządne dla jabłka
         * tak długo aż nie znajdziesz pola
         * nie zajętego przez ogon
         */
        appleCollidesWithTail = true;
        while (appleCollidesWithTail == true) {

            appleCollidesWithTail = false;

            tempAppleX = Math.floor(Math.random() * tileCount);
            tempAppleY = Math.floor(Math.random() * tileCount);

            for (var i = 0; i < trail.length; i++) {
                if (trail[i].x == tempAppleX && trail[i].y == tempAppleY)
                    appleCollidesWithTail = true;
            }
        }

        // ustaw nowe współrzędne jabłka
        appleX = tempAppleX;
        appleY = tempAppleY;


    }
    // wyrysuj jabłko
    ctx.fillStyle = "red";
    ctx.fillRect(appleX * gridSize, appleY * gridSize, gridSize - 2, gridSize - 2);
}

// funkcja sprawdzająca czy nie została wciśnięta strzałka
function keyPush(evt) {
    switch (evt.keyCode) {
        case 37:
        case 65:
            if (velocityX != 1) {
                velocityX = -1;
                velocityY = 0;
            }
            break;
        case 38:
        case 87:
            if (velocityY != 1) {
                velocityX = 0;
                velocityY = -1;
            }
            break;
        case 39:
        case 68:
            if (velocityX != -1) {
                velocityX = 1;
                velocityY = 0;
            }
            break;
        case 40:
        case 83:
            if (velocityY != -1) {
                velocityX = 0;
                velocityY = 1;
            }
            break;
    }
}