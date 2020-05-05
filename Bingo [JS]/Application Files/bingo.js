
var Matrix = function (dimension) {

    // this.name                    : name of player (i.e. 'Player' OR 'CPU')
    // this.dimension               : dimension is for size of the matrix (e.g. 5x5 OR 6x6 OR 7x7)
    // this.totalRandomNumbers      : how many random numbers to be generated

    // this.masterArray[]           : this array[] contains 3 arrays : [0]=>indexesArray[], [1]=>randomNumbersArray[], [2]=>flagsArray[] 
    // this.indexesArray[]          : this array[] stores id's of the buttons displayed on the matrix
    // this.randomNumbersArray[]    : this array[] will store actual random numbers (P.S. Numbers will not be repeated)
    // this.flagsArray[]            : this array[] stores flag values (i.e. 0 : unmarked button OR 1 : marked button) 

    // this.bingoStringArray[]      : this array[] will store BINGO STRING CHARACTERS (i.e. 'A','B','C','D','E',...) with their flag values

    this.name = ''
    this.dimension = dimension
    this.totalRandomNumbers = dimension * dimension
    this.masterArray = new Array(3)
    this.indexesArray = []
    this.randomNumbersArray = []
    this.flagsArray = []
    this.bingoStringArray = new Array(2)

    this.flagCount = new Array(3)

    this.gameStatus = 'START'

    this.generateRandomNumbers = function () {

        for (let index = 0; index < this.totalRandomNumbers; index++) {
            this.indexesArray.push(index)
            this.flagsArray.push(0)
        }

        while (this.randomNumbersArray.length != this.totalRandomNumbers) {
            let randomNumber = Math.floor(Math.random() * this.totalRandomNumbers) + 1

            if (this.randomNumbersArray.indexOf(randomNumber) === -1) {
                this.randomNumbersArray.push(randomNumber)
            }
        }

        this.masterArray[0] = this.indexesArray
        this.masterArray[1] = this.randomNumbersArray
        this.masterArray[2] = this.flagsArray

        this.bingoStringArray[0] = new Array(this.dimension) //['A','B','C','D','E','F','G','H','I']
        this.bingoStringArray[1] = new Array(this.dimension) //[0,0,0,0,0,0,0,0,0]

        for (let indexChar = 65, indexArray = 0; indexChar < (65 + this.dimension); indexChar++ , indexArray++) {
            this.bingoStringArray[0][indexArray] = (String.fromCharCode(indexChar))
            this.bingoStringArray[1][indexArray] = 0
        }



        this.flagCount[0] = new Array(this.dimension)
        this.flagCount[1] = new Array(this.dimension)
        this.flagCount[2] = new Array(this.dimension)

        this.flagCount[0][0] = 0
        this.flagCount[1][0] = 0 + this.dimension - 1
        this.flagCount[2][0] = 0

        for (let index = 1; index < this.dimension; index++) {
            this.flagCount[0][index] = this.flagCount[0][index - 1] + this.dimension
            this.flagCount[1][index] = this.flagCount[1][index - 1] + this.dimension
            this.flagCount[2][index] = 0
        }

    }

    this.renderMatrix = function (tableId) {

        this.name = tableId === 'playerMatrix' ? 'Player' : 'CPU'

        let table = document.getElementById(tableId)

        for (let indexRow = 0, indexRandomNumber = 0, indexButton = 0; indexRow < this.dimension; indexRow++) {

            let tableRow = document.createElement('tr')
            for (let indexColumn = 0; indexColumn < this.dimension; indexColumn++) {

                let tabledata = document.createElement('td')

                let buttonValue
                if (this.randomNumbersArray[indexRandomNumber] < 10) buttonValue = ` ${this.randomNumbersArray[indexRandomNumber]} `
                else buttonValue = this.randomNumbersArray[indexRandomNumber]

                let button = document.createElement('input')
                button.setAttribute('type', 'button')
                button.setAttribute('class', `button ${tableId}_button`)
                button.setAttribute('id', `${tableId}_${this.indexesArray[indexButton]}`)
                button.setAttribute('value', buttonValue)

                if (tableId === 'playerMatrix') {
                    button.setAttribute('onclick', `clickButtonFunctionCaller(${button.getAttribute('id')},${tableId + '.clickButtonByPlayer'},${tableId})`)
                }
                // else if(tableId === 'cpuMatrix'){
                //     button.setAttribute('onclick',`clickButtonByCpu(${button.getAttribute('id')},${tableId})`)
                // }

                tabledata.appendChild(button)
                tableRow.appendChild(tabledata)

                indexRandomNumber++
                indexButton++
            }

            table.appendChild(tableRow)
        }

        table.appendChild(document.createElement('br'))
        table.appendChild(document.createElement('br'))

        tableRow = document.createElement('tr')

        for (let indexRow = 0; indexRow < this.dimension; indexRow++) {

            let tabledata = document.createElement('td')

            let button = document.createElement('input')
            button.setAttribute('type', 'button')
            button.setAttribute('class', `button ${tableId}_bingo_button`)
            button.setAttribute('id', `${tableId}_${this.bingoStringArray[0][indexRow]}`)
            button.setAttribute('value', this.bingoStringArray[0][indexRow])

            tabledata.appendChild(button)
            tableRow.appendChild(tabledata)
        }

        table.appendChild(tableRow)
    }

}

Matrix.prototype.clickButtonByPlayer = function (button, tableId) {

    let buttonId
    let buttonIdNumber
    let buttonValue

    if (tableId.gameStatus === 'START') {

        buttonId = button.getAttribute('id')
        buttonIdNumber = buttonId.slice(buttonId.indexOf('_') + 1, buttonId.length)
        buttonValue = tableId.masterArray[1][buttonIdNumber]

        tableId.markButtonArray(tableId, buttonId, buttonIdNumber)
        tableId.markBingoStringArray(tableId, buttonIdNumber)

        console.log(`${tableId.name} clicked [${buttonValue}] with ID [${buttonId}]`)

        // tableId.checkWinner()



        tableId = cpuMatrix

        buttonIdNumber = tableId.masterArray[1].indexOf(buttonValue)
        buttonId = 'cpuMatrix_' + buttonIdNumber

        tableId.markButtonArray(tableId, buttonId, buttonIdNumber)
        tableId.markBingoStringArray(tableId, buttonIdNumber)

        tableId.checkWinner()
    }

    if (tableId.gameStatus === 'START') {

        tableId.clickButtonByCpu()
    }

}

Matrix.prototype.clickButtonByCpu = function () {


    let tableId = cpuMatrix

    let buttonId
    let buttonIdNumber
    let buttonValue

    if (tableId.gameStatus === 'START') {

        let cpuChoice
        let cpuChoiceIndex
        let cpuChoiceFlag = 1

        while (cpuChoiceFlag === 1) {
            cpuChoice = Math.floor(Math.random() * this.totalRandomNumbers) + 1
            cpuChoiceIndex = tableId.masterArray[1].indexOf(cpuChoice)
            cpuChoiceFlag = tableId.masterArray[2][cpuChoiceIndex]
        }

        buttonId = 'cpuMatrix_' + cpuChoiceIndex
        buttonIdNumber = cpuChoiceIndex
        buttonValue = cpuChoice


        tableId.markButtonArray(tableId, buttonId, buttonIdNumber)
        tableId.markBingoStringArray(tableId, buttonIdNumber)

        console.log(`${tableId.name} clicked [${buttonValue}] with ID [${buttonId}]`)





        let maxCount = 0
        for (let index = 0; index < tableId.dimension; index++) {

            for (let indexCount = tableId.flagCount[0][index]; indexCount < tableId.flagCount[1][index]; indexCount++) {

                if (tableId.masterArray[2][indexCount] === 1) {
                    tableId.flagCount[2][index]++
                    if (tableId.flagCount[2][index] > maxCount) {
                        maxCount = tableId.flagCount[2][index]
                    }
                }
            }
        }

        console.log(tableId.flagCount[2])
        console.log(`MAX COUNT : ${maxCount}`)




        // tableId.checkWinner()
        // }

        // if(tableId.gameStatus === 'START'){

        tableId = playerMatrix

        buttonIdNumber = tableId.masterArray[1].indexOf(buttonValue)
        buttonId = 'playerMatrix_' + buttonIdNumber

        tableId.markButtonArray(tableId, buttonId, buttonIdNumber)
        tableId.markBingoStringArray(tableId, buttonIdNumber)

        tableId.checkWinner()
    }
}

Matrix.prototype.markButtonArray = function (tableId, buttonId, buttonIdNumber) {

    if (tableId.masterArray[2][buttonIdNumber] !== 1) {
        tableId.masterArray[2][buttonIdNumber] = 1

        tableId.markButton(tableId, buttonId, buttonIdNumber)
    }
}

Matrix.prototype.markButton = function (tableId, buttonId, buttonIdNumber) {

    for (let indexButton = 0; indexButton < tableId.masterArray[2].length; indexButton++) {
        if (tableId.masterArray[2][buttonIdNumber] === 1) {
            let markedButton = document.getElementById(buttonId)
            markedButton.style.backgroundColor = `${tableId.name}Matrix` === 'PlayerMatrix' ? '#80bfff' : '#ff704d'
            markedButton.style.color = 'white'//`${tableId.name}Matrix` === 'CPUMatrix' ? '#80bfff' : '#ff704d'
            markedButton.setAttribute('disabled', true)
        }
    }
}

Matrix.prototype.markBingoStringArray = function (tableId, buttonIdNumber) {

    let countSequence = 0
    let conditionDiagonalOne = parseInt(buttonIdNumber % (this.dimension + 1)) === 0
    let conditionDiagonalTwo = parseInt(buttonIdNumber % (this.dimension - 1)) === 0

    if (tableId.checkHorizontalSequence(tableId, buttonIdNumber)) countSequence++
    if (tableId.checkVerticalSequence(tableId, buttonIdNumber)) countSequence++

    if (parseInt(buttonIdNumber) === 0 || parseInt(buttonIdNumber) === this.totalRandomNumbers - 1) {
        if (tableId.checkFirstDiagonalSequence(tableId, buttonIdNumber)) countSequence++
    }
    else {
        if (conditionDiagonalOne && conditionDiagonalTwo) {
            if (tableId.checkFirstDiagonalSequence(tableId, buttonIdNumber)) countSequence++
            if (tableId.checkSecondDiagonalSequence(tableId, buttonIdNumber)) countSequence++
        }
        else if (conditionDiagonalOne) {
            if (tableId.checkFirstDiagonalSequence(tableId, buttonIdNumber)) countSequence++
        }
        else if (conditionDiagonalTwo) {
            if (tableId.checkSecondDiagonalSequence(tableId, buttonIdNumber)) countSequence++
        }
    }

    // console.log(`countSequence : ${countSequence}`)

    let indexBingoStringArrayStart = tableId.bingoStringArray[1].lastIndexOf(1) + 1
    let indexBingoStringArrayEnd = tableId.bingoStringArray[1].length

    if (countSequence > 0) {

        let indexBingoStringArray = indexBingoStringArrayStart
        for (let index = 0; index < countSequence; index++) {

            if (indexBingoStringArray < indexBingoStringArrayEnd) {
                tableId.bingoStringArray[1][indexBingoStringArray++] = 1
            }
        }
        tableId.markBingoString(tableId, buttonIdNumber)
    }
}

Matrix.prototype.markBingoString = function (tableId, buttonIdNumber) {

    for (let index = 0; index < tableId.bingoStringArray[1].length; index++) {
        if (tableId.bingoStringArray[1][index] === 1) {
            let markedButton = document.getElementById(`${tableId.name.toLowerCase()}Matrix_${tableId.bingoStringArray[0][index]}`)
            markedButton.style.backgroundColor = `${tableId.name}Matrix` === 'PlayerMatrix' ? '#80bfff' : '#ff704d'
        }
    }

    // tableId.checkWinner()
}

Matrix.prototype.checkWinner = function () {

    let player = playerMatrix
    let cpu = cpuMatrix

    let playerWonCondition = player.bingoStringArray[1][player.dimension - 1]
    let cpuWonCondition = cpu.bingoStringArray[1][cpu.dimension - 1]

    // console.log(playerWonCondition)
    // console.log(cpuWonCondition)

    if (playerWonCondition === 1 && cpuWonCondition === 1) {
        console.log(`It's a tie... Well played!!!`)
        alert(`It's a tie... Well played!!!`)
        this.endGame(player)
    }
    else if (playerWonCondition === 1) {
        console.log(`Player won`)
        alert(`Player won`)
        this.endGame(player)
    }
    else if (cpuWonCondition === 1) {
        console.log(`CPU won`)
        alert(`CPU won`)
        this.endGame(player)
    }

}

Matrix.prototype.endGame = function (tableId) {

    for (let index = 0; index < tableId.masterArray[0].length; index++) {
        let button = document.getElementById(`playerMatrix_${tableId.masterArray[0][index]}`)
        button.setAttribute('disabled', 'true')
    }

    console.log(playerMatrix.gameStatus)
    console.log(cpuMatrix.gameStatus)

    playerMatrix.gameStatus = 'STOP'
    cpuMatrix.gameStatus = 'STOP'

    console.log(playerMatrix.gameStatus)
    console.log(cpuMatrix.gameStatus)
}

Matrix.prototype.checkHorizontalSequence = function (tableId, buttonIdNumber) {

    let indexHorizontalRangeStart
    let indexHorizontalRangeEnd

    indexHorizontalRangeStart = parseInt(buttonIdNumber / this.dimension)
    indexHorizontalRangeStart += parseInt(indexHorizontalRangeStart * (this.dimension - 1))
    indexHorizontalRangeEnd = parseInt(indexHorizontalRangeStart + (this.dimension - 1))

    for (let index = indexHorizontalRangeStart; index <= indexHorizontalRangeEnd; index++) {
        if (tableId.masterArray[2][index] !== 1) {
            return false
        }
    }

    return true
}

Matrix.prototype.checkVerticalSequence = function (tableId, buttonIdNumber) {

    let indexVerticalRangeStart
    let indexVerticalRangeEnd

    indexVerticalRangeStart = parseInt(buttonIdNumber % this.dimension)
    indexVerticalRangeEnd = parseInt(indexVerticalRangeStart + (this.dimension * (this.dimension - 1)))

    for (let index = indexVerticalRangeStart; index <= indexVerticalRangeEnd; index += this.dimension) {
        if (tableId.masterArray[2][index] !== 1) {
            return false
        }
    }

    return true
}

Matrix.prototype.checkFirstDiagonalSequence = function (tableId, buttonIdNumber) {

    let indexDiagonalRangeStart
    let indexDiagonalRangeEnd

    indexDiagonalRangeStart = 0
    indexDiagonalRangeEnd = this.totalRandomNumbers - 1

    // console.log('first')

    for (let index = indexDiagonalRangeStart; index <= indexDiagonalRangeEnd; index += (this.dimension + 1)) {
        if (tableId.masterArray[2][index] !== 1) {
            return false
        }
    }

    return true
}

Matrix.prototype.checkSecondDiagonalSequence = function (tableId, buttonIdNumber) {

    let indexDiagonalRangeStart
    let indexDiagonalRangeEnd

    indexDiagonalRangeStart = 0 + (this.dimension - 1)
    indexDiagonalRangeEnd = this.totalRandomNumbers - this.dimension

    // console.log('second')

    for (let index = indexDiagonalRangeStart; index <= indexDiagonalRangeEnd; index += (this.dimension - 1)) {
        if (tableId.masterArray[2][index] !== 1) {
            return false
        }
    }

    return true
}

function startGame() {

    playerMatrix = new Matrix(7)
    playerMatrix.generateRandomNumbers()
    playerMatrix.renderMatrix('playerMatrix')

    console.log(`++++++++Player Matrix++++++++`)
    console.log(`indexes[] => ${playerMatrix.masterArray[0]}`)
    console.log(`randomNumbers[] => ${playerMatrix.masterArray[1]}`)
    console.log(`flags[] => ${playerMatrix.masterArray[2]}`)
    console.log(`+++++++++++++++++++++++++++++`)

    ///////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////

    cpuMatrix = new Matrix(7)
    cpuMatrix.generateRandomNumbers()
    cpuMatrix.renderMatrix('cpuMatrix')

    console.log(`++++++++++CPU Matrix+++++++++`)
    console.log(`indexes[] => ${cpuMatrix.masterArray[0]}`)
    console.log(`randomNumbers[] => ${cpuMatrix.masterArray[1]}`)
    console.log(`flags[] => ${cpuMatrix.masterArray[2]}`)
    console.log(`+++++++++++++++++++++++++++++`)

}

function clickButtonFunctionCaller(button, fn, tableId) {

    // Callback Function
    fn(button, tableId)

}







// Matrix.prototype.clickButtonByPlayer = function(button) {

//     let buttonId = button.getAttribute('id')
//     let buttonIdNumber = buttonId.slice(buttonId.indexOf('_') + 1,buttonId.length)
//     let buttonValue = playerMatrix.masterArray[1][buttonIdNumber]

//     markButtonArray('playerTable',buttonId,buttonIdNumber)

//     console.log(`Player clicked [${buttonValue}] with ID [${buttonId}]`)
// }

// Matrix.prototype.clickButtonByCpu = function(button) {

//     let buttonId = button.getAttribute('id')
//     let buttonIdNumber = buttonId.slice(buttonId.indexOf('_') + 1,buttonId.length)
//     let buttonValue = cpuMatrix.masterArray[1][buttonIdNumber]

//     console.log(`CPU clicked [${buttonValue}] with ID [${buttonId}]`)
// }