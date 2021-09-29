var wavesurfer = WaveSurfer.create({
    container: '#waveform',
    waveColor: '#D2EDD4',
    progressColor: 'purple',
    barWidth: 3,
    height: 90,
    responsive: true,
    hideScrollbar: true,
    barRadius: 4
});
var sayac = 0;
var mylist = [];
const liste = document.getElementById("musicList").getElementsByTagName("input")
function filled() {
    const music = {
        musicUrl: "",
        title: "",
        image: ""
    }

    for (let i = 0; i < liste.length; i++) {
        var _music = Object.create(music);
        _music.title = liste[i].id;
        _music.image = liste[i].name
        _music.musicUrl = liste[i].defaultValue
        mylist.push(_music);

    }
    wavesurfer.load(mylist[sayac].musicUrl)
    document.getElementById("img").setAttribute("src", mylist[sayac].image)
    document.getElementById("title").innerText=mylist[sayac].title
}

filled()
function Play() {
    if (document.getElementById("play").className == "fas fa-play-circle fa-2x") {
        document.getElementById("play").className = "fas fa-pause-circle fa-2x"
        wavesurfer.playPause();
    } else {
        document.getElementById("play").className = "fas fa-play-circle fa-2x"
        wavesurfer.playPause();
    }
}

function Stop() {
    wavesurfer.stop();
    document.getElementById("play").className = "fas fa-play-circle fa-2x"
}

function Mute() {
    if (document.getElementById("mute").className == "fas fa-volume-up  fa-2x") {
        document.getElementById("mute").className = "fas fa-volume-mute  fa-2x"
    } else {
        document.getElementById("mute").className = "fas fa-volume-up  fa-2x"
    }
    wavesurfer.toggleMute();

}

async function Next() {
    if (sayac < mylist.length-1) {
        ++sayac;
        await  wavesurfer.load(mylist[sayac].musicUrl)
        document.getElementById("img").setAttribute("src", mylist[sayac].image)
        document.getElementById("title").innerText=mylist[sayac].title
        Stop()
    }
}
async function Back ()  {
    if (sayac > 0) {
        --sayac;
        await wavesurfer.load(mylist[sayac].musicUrl)
        document.getElementById("img").setAttribute("src", mylist[sayac].image)
        document.getElementById("title").innerText=mylist[sayac].title
        Stop()
    }
}
