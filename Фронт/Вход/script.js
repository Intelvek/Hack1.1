    window.onload = function () {
        document.getElementById('fullName').oninput = function (){
            this.value = this.value.replace(/[0-9]/g, '');
        }

        document.getElementById('userName').oninput = function (){
            this.value = this.value.replace(/[.,]/g, '')
        }
        document.getElementById('userName').oninput = function (){
            this.value = this.value.replace(/[.,]/g, '')
        }

        document.getElementById('checkOr').onchange = (e) => {
            if (e.target.checked === true){
                console.log('Выбран')
            } else{
                console.log('Ошибка! Чекбокс не выбран')
            }
        }


        document.getElementById('signBut').onclick = function sign (){
            if (!document.getElementById('fullName').value){
                alert('Заполните ваше имя');
                return;
            }
            if (!document.getElementById('userName').value){
                alert('Заполните ваш псевдоним');
                return;
            }
            if (!document.getElementById('emailIn').value){
                alert('Заполните ваш E-mail');
                return;
            }
            if (!document.getElementById('passIn').value){
                alert('Заполните ваш пароль');
                return;
            }
            if (!document.getElementById('repPassIn').value){
                alert('Повторите ваш пароль');
                return;
            }

            if ( document.getElementById('passIn').value.length < 8 ){
                alert('Ошибка! Пароль должен быть не менее восьми символов');
                return;
            }

            if (document.getElementById('passIn').value.length !== document.getElementById('repPassIn').value.length){
                alert('Пароли не совпадают');
                return;
            }

            if (document.getElementById('checkOr') === false){
                alert('Не выбран чекбокс');
                // return;
            }
            //
            // document.getElementById('signBut').onclick = function () {
            //     document.getElementById('div-popup').classList.add('open');
            // };



    }




    };



