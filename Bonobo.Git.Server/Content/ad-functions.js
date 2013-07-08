function changePWElements(page,checked) {
    if(page == "edit"){
        var oldPw = document.getElementById('OldPassword')
        var oldPwDiv = document.getElementById('oldPW')
        var newPw = document.getElementById('NewPassword')
        var newPwDiv = document.getElementById('newPW')
        
        if (checked) {
            if (oldPw != null) {
                oldPw.value = "ad";
                oldPwDiv.style.display = 'none';
            }
            newPw.value = "ad";
            newPwDiv.style.display = 'none';
        } else {
            if (oldPw != null) {
                oldPw.value = "";
                oldPwDiv.style.display = 'block';
            }
            newPw.value = "";
            newPwDiv.style.display = 'block';
        }
    }

    if (page == 'create') {
        var pw = document.getElementById('Password')
        var pwDiv = document.getElementById('pw')

        if (checked) {
            pw.value = "ad";
            pwDiv.style.display = 'none';
        }else {
            pw.value = "";
            pwDiv.style.display = 'block';
        }
    }

    var confirmPw = document.getElementById('ConfirmPassword')
    var confirmPwDiv = document.getElementById('confirmPW')

    if (checked) {
        confirmPw.value = "ad";
        confirmPwDiv.style.display = 'none';
    }else {
        confirmPw.value = "";
        confirmPwDiv.style.display = 'block';
    }
}