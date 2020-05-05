
var statementView = (function () {

    var json_object = model.getJsonObject()

    if (json_object.session === '1') {
        var statementBody = model.statementBody
        var statements = json_object.statement.split(';')

        for (let index = 0; index < statements.length; index++) {

            if (index < 5) {
                let row = statements[index].split(',')
                let color

                if (row[1] === 'Deposit') color = 'text-primary'
                else color = 'text-danger'

                statementBody.append(`<tr><td class=${color}>${row[0]}</td>
                                  <td class=${color}>${row[1]}</td>
                                  <td class=${color}>${row[2]}</td>
                                  <td class=${color}>${row[3]}</td>
                            </tr>`)
            }
            else {
                break
            }
        }
    }
    else {
        window.location.replace('index.html')
    }

})()
