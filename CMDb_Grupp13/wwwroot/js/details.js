const baseEndpoint = 'https://grupp9.dsvkurs.miun.se/api/'
const imdbID = document.querySelector('#Movie_imdbID').value 
const likeEndpoint = '/like'
const dislikeEndpoint = '/dislike'

let likesData
let dislikesData

let urlIncrease = (baseEndpoint + imdbID + likeEndpoint)
let urlDecrease = (baseEndpoint + imdbID + dislikeEndpoint)

document.querySelector('.likeButton').addEventListener('click', increaseLikes)
document.querySelector('.dislikeButton').addEventListener('click', increaseDislikes)

async function increaseLikes() {
    try
    {
        const res = await fetch(urlIncrease)
        likesData = await res.json()
        displayLikes(likesData)
    }
    catch (error)
    {
        console.log(error)
    }
}

function displayLikes(likesData) {
    document.querySelector('.numberOfLikes').textContent = likesData.numberOfLikes
    disableButtons()
}

async function increaseDislikes() {
    try {
        const res = await fetch(urlDecrease)
        dislikesData = await res.json()
        displayDislikes(dislikesData)
    }
    catch (error) {
        console.log(error)
    }
}

function displayDislikes(dislikesData) {
    document.querySelector('.numberOfDislikes').textContent = dislikesData.numberOfDislikes
    disableButtons()
}

function disableButtons() {
    document.querySelector('.likeButton').disabled = true;
    document.querySelector('.dislikeButton').disabled = true;
}


