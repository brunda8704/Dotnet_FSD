const listItems = document.querySelectorAll(".list-group-item");

listItems.forEach((item) => {
    item.addEventListener("click", () => {
        // get song title
        const songTitle = item.querySelector("small").textContent;

        // show message in footer
        const footer = document.getElementById("footer");
        footer.innerHTML = `
        <div class="row bg-dark">
            <div class="col-md-12 text-white text-center">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-play-fill d-inline" viewBox="0 0 16 16">
                <path d="m11.596 8.697-6.363 3.692c-.54.313-1.233-.066-1.233-.697V4.308c0-.63.692-1.01 1.233-.696l6.363 3.692a.802.802 0 0 1 0 1.393z"/>
                </svg>
                
                <p class="d-inline">Now playing</p>
                <p id="now-playing" class="text-white">${songTitle}</p>
                <div id="progress-bar" class="progress mx-auto text-center mb-2" style="height: 3px; width: 50%;">
                    <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
            </div>
        </div>`;
    });
});

document.addEventListener("DOMContentLoaded", function () {
    const audioPlayer = document.getElementById("audioPlayer");
    const audioSource = document.getElementById("audioSource");
    const songElements = document.getElementsByClassName("song");

    // click event for each small event
    for (let i = 0; i < songElements.length; i++) {
        const songElement = songElements[i];
        songElement.addEventListener("click", function () {
            const audioSrc = this.getAttribute("data-src");
            audioSource.src = audioSrc;
            audioPlayer.load(); // reload audio with new source
            audioPlayer.play(); // play audio
        });
    }
});
