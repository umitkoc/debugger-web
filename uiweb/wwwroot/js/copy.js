function Copy(){
    document.getElementById("avatar2").setAttribute("src",document.getElementById("avatar1").getAttribute("src"))
    document.getElementById("job2").innerText=document.getElementById("job1").innerText
}
Copy();