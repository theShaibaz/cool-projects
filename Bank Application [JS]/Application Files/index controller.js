
var controller = (function () {

    var username = model.username
    var password = model.password
    var login = model.login

    login.click(() => {

        if (username.val().trim() === '' || password.val().trim() === '') {
            console.error('validation error')
            error('Enter username & password', 'Login Failed')
        }
        else {

            var json_object = model.getJsonObject()

            if (json_object.username === username.val() && json_object.password === password.val()) {
                console.log('login successful')

                json_object.session = '1'
                model.updateJsonObject(json_object)

                window.location.replace('dashboard.html')
            }
            else {
                console.error('login failed')
                error('Incorrect username or password', 'Login Failed')
            }
        }
    })

})()
