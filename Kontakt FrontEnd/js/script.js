// Main Slider Start
let leftBtn=document.querySelector("#main-slider .left")
let rightBtn=document.querySelector("#main-slider .right")

setInterval(function(){ 
    let active=document.querySelector("#main-slider .active")
    if (active.nextElementSibling!=null) {
     active.nextElementSibling.classList.add("active")
    }
    else{
     active.parentNode.firstElementChild.classList.add("active")
    }
    active.classList.remove("active")
 }, 3000);
leftBtn.addEventListener("click",function(){
    let active=document.querySelector("#main-slider .active")
    if (active.previousElementSibling!=null) {
        active.previousElementSibling.classList.add("active")
       }
       else{
        active.parentNode.lastElementChild.classList.add("active")
       }
       active.classList.remove("active")
})
rightBtn.addEventListener("click",function(){
    let active=document.querySelector("#main-slider .active")
   if (active.nextElementSibling!=null) {
    active.nextElementSibling.classList.add("active")
   }
   else{
    active.parentNode.firstElementChild.classList.add("active")
   }
   active.classList.remove("active")
})
// Main Slider End

//Right Daily Slider Swiper Start

const swiper =new Swiper('.slider-price-drag-card',{
    //navigation click
    

    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev'
    },
    //pagination
    pagination:{
        el: '.swiper-pagination',
        clickable:true,
        dynamicBullets:true,
    },

    //Avtoplay intervar
    autoplay: {
        delay:3000,
        stopOnLastSlide:true,
        disableOnInteraction:false,
    },
    speed: 800,
    loop:true,

});
//Right Daily Slider Swiper End

//Carousel Products Start
new Swiper('.carouseldiv',{
    // pagination:{
    //     el: '.swiper-pagination',
    //     clickable:true,
    // },
    
    watchOverflow:true,
    
    autoplay: {
        delay:1000,
        stopOnLastSlide:true,
        disableOnInteraction:false,
    },
    loop:true,
    speed: 800,
    breakpoints:{
        480:{
            slidesPerView:2.3,
        },
        992:{
            slidesPerView:3.5,
        },
        1200:{
            slidesPerView: 4.5,
        }
    }
});
//Carousel Products End

// Carousel Partners  Start
new Swiper('.partners-main',{
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev'
    },
    watchOverflow:true,
    autoplay: {
        delay:5000,
        stopOnLastSlide:true,
        disableOnInteraction:false,
    },
    loop:true,
    speed: 300,
    breakpoints:{
        480:{
            slidesPerView:3,
        },
        992:{
            slidesPerView:4,
        },
        1200:{
            slidesPerView: 8,
        }
    }
  
});


