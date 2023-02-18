document.getElementById('signBut').onclick = function () {
    document.getElementById('div-popup').classList.add('open');
};


// if (document.getElementById('signBut').onclick){
//   confirm('На вашу почту выслана ссылка, перейдите по ней, чтобы завершить регистрацию');
// }

// document.getElementById('signBut').onclick = function () {
//     if (sign === true){
//         confirm('На вашу почту выслана ссылка, перейдите по ней, чтобы завершить регистрацию');
//     } else {
//         alert('Вы указали не всю информацию')
//     }
// }

document.getElementById('signBut').onclick = function () {
    document.getElementById('div-popup').classList.add('open');
}
document.getElementById('pop-button').forEach((item) => {
    item.onclick = () => {
        document.getElementById('pop-button').classList.remove('open');
    }
})


