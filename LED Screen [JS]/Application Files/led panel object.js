
// Panel class
var Panel = function(text,panelWidthHidden,panelWidthVisible){

    // Text to display on panel
    this.text = text.toUpperCase()
    // Width of the LED panel as per the user input
    this.panelWidthHidden = panelWidthHidden
    // Actual width of the LED panel which will be visible to the user 
    this.panelWidthVisible = panelWidthVisible

    // Array to store the ID's of DIV's which needs to glowed (i.e. change the color)
	this.pixelsToGlow = []
	// Array to store counters which will be used for inserting DIV ID's into pixelsToGlow[]
	this.lineCounters = [] 
	// This array will contain DIV ID's which are at leftmost side of each row
	this.lineCounterStart = []
	// This array will contain DIV ID's which are at rightmost side of each row
    this.lineCounterLimits = []
    
}

// *** Adding methods through prototype model ***

Panel.prototype.initializePanel = function(){

	// Variable for creating DOM elements
    counterId = ++lastCounter

    console.log(`Panel counter start : ${lastCounter}`)
    
	let _table
	let _tr
	let _td			
	let _div

	// Creating TABLE
	_table = document.createElement("table")
	_table.setAttribute("align","center")

	for(let indexRow = 1; indexRow <= 10; indexRow++){

		// Creating TR
		_tr = document.createElement("tr")

		for(let indexColumn = 1; indexColumn <= this.panelWidthHidden; indexColumn++){

			// Creating DIV and asigning them ID's
			// Then placing them inside the TD and TR
			_div = document.createElement("div")
			_div.setAttribute("id",counterId)
			_td = document.createElement("td")
			_td.appendChild(_div)
			_tr.appendChild(_td)

			// Condition for hiding some pixels (i.e. DIV's)
			// This is because if user enters a long text which is not fitting
			// width of computer screen then that remaing text will be hidden first
			// When timer starts it will become visible on the panel as text moves
			let conditionVisibility = indexColumn > this.panelWidthVisible && indexColumn <= this.panelWidthHidden	

			// Hiding DIV's as per the condition
			if(conditionVisibility){
				_div.setAttribute("hidden",true)
			} 

			counterId++
		}

		// Adding TR to TABLE
		_table.appendChild(_tr)
	}
	
	// Adding TABLE to BODY
    document.body.appendChild(_table)
    document.body.appendChild(document.createElement("br"))
}

Panel.prototype.printLetters = function() {
	
	// Inserting DIV ID's of leftmost side of each row as a starting point
	// for counter of each row
	// Values of this array will change after the execution
	this.lineCounters.push(lastCounter)
	this.lineCounters.push(this.lineCounters[0] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[1] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[2] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[3] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[4] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[5] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[6] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[7] + this.panelWidthHidden)
	this.lineCounters.push(this.lineCounters[8] + this.panelWidthHidden)

	// Inserting DIV ID's of leftmost side of each row as a starting point
	// for starting DIV of each row
	// Values of this array are fixed
	this.lineCounterStart.push(lastCounter)
	this.lineCounterStart.push(this.lineCounterStart[0] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[1] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[2] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[3] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[4] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[5] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[6] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[7] + this.panelWidthHidden)
	this.lineCounterStart.push(this.lineCounterStart[8] + this.panelWidthHidden)

    
	// Inserting DIV ID's of rightmost side of each row as a ending point
	// for ending DIV of each row
	// Values of this array are fixed
	this.lineCounterLimits.push(lastCounter + this.panelWidthHidden - 1)
	this.lineCounterLimits.push(this.lineCounterLimits[0] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[1] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[2] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[3] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[4] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[5] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[6] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[7] + this.panelWidthHidden)
	this.lineCounterLimits.push(this.lineCounterLimits[8] + this.panelWidthHidden)
    
    lastCounter = --counterId

    console.log(`Panel counter end : ${lastCounter}`)
    console.log(`lineCounterStart[] : ${this.lineCounterStart}`)
    console.log(`lineCounterLimits[] : ${this.lineCounterLimits}`)

	// Checking each letter from the text and mapping it's pixels (i.e. DIV's)
	// line by line
	// Note : Each letter will be mapped to [10 rows x 10 columns]
	for (let indexLine = 1; indexLine <= 10; indexLine++) {
		
		for (let indexText = 0; indexText < this.text.length; indexText++) {
			
			// Calling mapLetters function which will return the DIV ID's
			// of which color should be changed
			this.pixelsToGlow = this.mapLetters(this.text.charAt(indexText),indexLine)

		}

	}

	// After getting the pixelsToGlow[] values this block of code 
	// will change color of those DIV's
	this.pixelsToGlow.forEach(pixel => {
		
		document.getElementById(pixel).style.backgroundColor = "#FF0000"
	});

}

Panel.prototype.moveLettersLeft = function(params){

    console.log(params[0])

    // params[0] = pixelsToGlow[]
    // params[1] = lineCounterStart[]
    // params[2] = lineCounterLimits[]

	// This will change the color of DIV's present inside pixelsToGlow[] to original color
	params[0].forEach(pixel => {
		
		document.getElementById(pixel).style.backgroundColor = "#FFC896"
		// document.getElementById(pixel).style.backgroundColor = "aquamarine"
	});

	// This code block will move each and every glowing pixel to the left side
	for (let pixel = 0; pixel < params[0].length; pixel++) {
		 
		if(params[0][pixel] == params[1][0]) params[0][pixel] = params[2][0]
		else if(params[0][pixel] == params[1][1]) params[0][pixel] = params[2][1]
		else if(params[0][pixel] == params[1][2]) params[0][pixel] = params[2][2]
		else if(params[0][pixel] == params[1][3]) params[0][pixel] = params[2][3]
		else if(params[0][pixel] == params[1][4]) params[0][pixel] = params[2][4]
		else if(params[0][pixel] == params[1][5]) params[0][pixel] = params[2][5]
		else if(params[0][pixel] == params[1][6]) params[0][pixel] = params[2][6]
		else if(params[0][pixel] == params[1][7]) params[0][pixel] = params[2][7]
		else if(params[0][pixel] == params[1][8]) params[0][pixel] = params[2][8]
		else if(params[0][pixel] == params[1][9]) params[0][pixel] = params[2][9]
		else params[0][pixel]--
		
	}
	

	// This will change the color of DIV's present inside pixelsToGlow[] to glowing color
	params[0].forEach(pixel => {
		
		document.getElementById(pixel).style.backgroundColor = "#FF0000"
		// document.getElementById(pixel).style.backgroundColor = "royalblue"
	});
}

Panel.prototype.moveLettersRight = function(params){
    
    console.log(params[0])

    // params[0] = pixelsToGlow[]
    // params[1] = lineCounterStart[]
    // params[2] = lineCounterLimits[]

	// This will change the color of DIV's present inside pixelsToGlow[] to original color
	params[0].forEach(pixel => {
		
		document.getElementById(pixel).style.backgroundColor = "#FFC896"
		// document.getElementById(pixel).style.backgroundColor = "aquamarine"
	});

	
	// This code block will move each and every glowing pixel to the right side
	for (let pixel = 0; pixel < params[0].length; pixel++) {

		if(params[0][pixel] == params[2][0]) params[0][pixel] = params[1][0]
		else if(params[0][pixel] == params[2][1]) params[0][pixel] = params[1][1]
		else if(params[0][pixel] == params[2][2]) params[0][pixel] = params[1][2]
		else if(params[0][pixel] == params[2][3]) params[0][pixel] = params[1][3]
		else if(params[0][pixel] == params[2][4]) params[0][pixel] = params[1][4]
		else if(params[0][pixel] == params[2][5]) params[0][pixel] = params[1][5]
		else if(params[0][pixel] == params[2][6]) params[0][pixel] = params[1][6]
		else if(params[0][pixel] == params[2][7]) params[0][pixel] = params[1][7]
		else if(params[0][pixel] == params[2][8]) params[0][pixel] = params[1][8]
		else if(params[0][pixel] == params[2][9]) params[0][pixel] = params[1][9]
		else params[0][pixel]++

	}

	// This will change the color of DIV's present inside pixelsToGlow[] to glowing color
	params[0].forEach(pixel => {
		
		document.getElementById(pixel).style.backgroundColor = "#FF0000"
		// document.getElementById(pixel).style.backgroundColor = "royalblue"
	});
}


// Here for the first time after getting text from the user
// mapLetters() will map each and every letter to specific pixels (i.e. DIV)
// This process will happen line by line and only once
Panel.prototype.mapLetters = function(character,indexLine) {

	// There are functions like patternOne() ... patternFourteen()
	// to map particular pattern to DIV IDs
	// e.g. " ******** "
	// The patterns which are repeating for them only functions are available
	// for else patterns code is directly written in switch cases
	if(character === ' '){
		
		switch (indexLine) {
			
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
                this.lineCounters[indexLine-1] += 11
			break;

		}
	}

	else if(character === 'A'){
		
		switch (indexLine) {
			
			case 1:
                this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
                this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 5:
                this.pixelsToGlow = this.patternThree(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'B'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;

		}
	}

	else if(character === 'C'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'D'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;

		}
	}

	else if(character === 'E'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternSix(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternSix(indexLine-1)
			break;

		}
	}

	else if(character === 'F'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternSix(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

		}
	}

	else if(character === 'G'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 3:
			case 4:
			case 5:
			case 6:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

			case 7:
				this.pixelsToGlow = this.patternSeven(indexLine-1)
			break;
			
			case 8:
			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'H'){
		
		switch (indexLine) {
			
			case 1:
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternThree(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'I'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow = this.patternEight(indexLine-1)
			break;

			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				this.pixelsToGlow = this.patternNine(indexLine-1)
			break;

			case 9:
				this.pixelsToGlow = this.patternEight(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'J'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternTen(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				this.pixelsToGlow = this.patternEleven(indexLine-1)
			break;

			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'K'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
				
				++this.lineCounters[indexLine-1]
			break;

			case 3:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
					
				++this.lineCounters[indexLine-1]
			break;
			
			case 4:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 7
						
				++this.lineCounters[indexLine-1]
			break;

			case 5:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 8
							
				++this.lineCounters[indexLine-1]
			break;
			
			case 6:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 8
								
				++this.lineCounters[indexLine-1]
			break;

			case 7:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 7
							
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
						
				++this.lineCounters[indexLine-1]
			break;

			case 9:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
					
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'L'){
		
		switch (indexLine) {
			
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'M'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
				
				++this.lineCounters[indexLine-1]
			break;

			case 3:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
					
				++this.lineCounters[indexLine-1]
			break;
			
			case 4:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
						
				++this.lineCounters[indexLine-1]
			break;

			case 5:
				this.pixelsToGlow = this.patternEight(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'N'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 2:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 7
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
							
				++this.lineCounters[indexLine-1]
			break;

			case 3:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
								
				++this.lineCounters[indexLine-1]
			break;
			
			case 4:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
									
				++this.lineCounters[indexLine-1]
			break;

			case 5:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
									
				++this.lineCounters[indexLine-1]
			break;
			
			case 6:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
									
				++this.lineCounters[indexLine-1]
			break;

			case 7:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
									
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
									
				++this.lineCounters[indexLine-1]
			break;

			case 9:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 7
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
										
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'O'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'P'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

		}
	}

	else if(character === 'Q'){
		
		switch (indexLine) {
			
			case 1:
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				
				++this.lineCounters[indexLine-1]
			break;
			
			case 2:
			case 3:
			case 4:
			case 5:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
						
				++this.lineCounters[indexLine-1]
			break;
			
			case 6:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
						
				++this.lineCounters[indexLine-1]
			break;

			case 7:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
							
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
					
				++this.lineCounters[indexLine-1]
			break;

			case 9:
                this.lineCounters[indexLine-1] += 8
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.pixelsToGlow = this.patternEleven(indexLine-1)
			break;

		}
	}

	else if(character === 'R'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternFour(indexLine-1)
			break;
			
			case 6:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
					
				++this.lineCounters[indexLine-1]
			break;

			case 7:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 5
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
						
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
						
				++this.lineCounters[indexLine-1]
			break;

			case 9:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 7
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
						
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'S'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
			case 3:
			case 4:
				this.pixelsToGlow = this.patternFive(indexLine-1)
			break;

			case 5:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 6:
			case 7:
			case 8:
			case 9:
				this.pixelsToGlow = this.patternEleven(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'T'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow = this.patternEight(indexLine-1)
			break;

			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternNine(indexLine-1)
			break;

		}
	}

	else if(character === 'U'){
		
		switch (indexLine) {
			
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternOne(indexLine-1)
			break;

		}
	}

	else if(character === 'V'){
		
		switch (indexLine) {
			
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

			case 7:
				this.pixelsToGlow = this.patternTwelve(indexLine-1)
			break;
			
			case 8:
				this.pixelsToGlow = this.patternThirteen(indexLine-1)
			break;

			case 9:
				this.pixelsToGlow = this.patternFourteen(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternNine(indexLine-1)
			break;

		}
	}

	else if(character === 'W'){
		
		switch (indexLine) {
			
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 6:
				this.pixelsToGlow = this.patternEight(indexLine-1)
			break;

			case 7:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2	
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
							
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1	
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
								
				++this.lineCounters[indexLine-1]
			break;

			case 9:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 6
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				++this.lineCounters[indexLine-1]
								
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'X'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow = this.patternTwelve(indexLine-1)
			break;

			case 3:
				this.pixelsToGlow = this.patternThirteen(indexLine-1)
			break;
			
			case 4:
				this.pixelsToGlow = this.patternFourteen(indexLine-1)
			break;

			case 5:
			case 6:
				this.pixelsToGlow = this.patternNine(indexLine-1)
			break;

			case 7:
				this.pixelsToGlow = this.patternFourteen(indexLine-1)
			break;
			
			case 8:
				this.pixelsToGlow = this.patternThirteen(indexLine-1)
			break;

			case 9:
				this.pixelsToGlow = this.patternTwelve(indexLine-1)
			break;
			
			case 10:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;

		}
	}

	else if(character === 'Y'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternTwo(indexLine-1)
			break;
			
			case 2:
				this.pixelsToGlow = this.patternTwelve(indexLine-1)
			break;

			case 3:
				this.pixelsToGlow = this.patternThirteen(indexLine-1)
			break;
			
			case 4:
				this.pixelsToGlow = this.patternFourteen(indexLine-1)
			break;

			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
				this.pixelsToGlow = this.patternNine(indexLine-1)
			break;

		}
	}

	else if(character === 'Z'){
		
		switch (indexLine) {
			
			case 1:
				this.pixelsToGlow = this.patternThree(indexLine-1)
			break;
			
			case 2:
                this.lineCounters[indexLine-1] += 7
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 2
									
				++this.lineCounters[indexLine-1]
			break;

			case 3:
                this.lineCounters[indexLine-1] += 6
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 3
										
				++this.lineCounters[indexLine-1]
			break;
			
			case 4:
                this.lineCounters[indexLine-1] += 5
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 4
											
				++this.lineCounters[indexLine-1]
			break;

			case 5:
                this.lineCounters[indexLine-1] += 4
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 5
											
				++this.lineCounters[indexLine-1]
			break;
			
			case 6:
                this.lineCounters[indexLine-1] += 3
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 6
											
				++this.lineCounters[indexLine-1]
			break;

			case 7:
                this.lineCounters[indexLine-1] += 2
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 7
											
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
                this.lineCounters[indexLine-1] += 1
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 8
											
				++this.lineCounters[indexLine-1]
			break;

			case 9:
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 9
											
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.pixelsToGlow = this.patternThree(indexLine-1)
			break;

		}
	}
	else{

		switch (indexLine) {
			
			case 1:
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
										
				++this.lineCounters[indexLine-1]
			break;
			
			case 2:
                this.lineCounters[indexLine-1] += 1
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 4
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 3
									
				++this.lineCounters[indexLine-1]
			break;

			case 3:
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 6
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 2
										
				++this.lineCounters[indexLine-1]
			break;
			
			case 4:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
				
				++this.lineCounters[indexLine-1]
			break;
				
			case 5:
				this.pixelsToGlow.push(this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 8
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 1
										
				++this.lineCounters[indexLine-1]
			break;
			
			case 6:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 3
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 3
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 1
											
				++this.lineCounters[indexLine-1]
			break;

			case 7:
                this.pixelsToGlow.push(this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 1
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 4
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 1
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 1
											
				++this.lineCounters[indexLine-1]
			break;
			
			case 8:
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 1
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 1
                this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
                this.lineCounters[indexLine-1] += 2
											
				++this.lineCounters[indexLine-1]
			break;

			case 9:
				this.lineCounters[indexLine-1] += 1
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 3
										
				++this.lineCounters[indexLine-1]
			break;
			
			case 10:
				this.lineCounters[indexLine-1] += 2
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.pixelsToGlow.push(++this.lineCounters[indexLine-1])
				this.lineCounters[indexLine-1] += 4
											
				++this.lineCounters[indexLine-1]
			break;

		}
	}

	// Returning updated pixelsToGlow[] 
	return this.pixelsToGlow
}


// functions to push DIV IDs to be glowed into pixelsToGlow[] as per the letter
Panel.prototype.patternOne = function (lineIndex) {
	// " ******** "
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 2

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternTwo = function (lineIndex) {
	// "*        *"
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 9
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternThree = function (lineIndex) {
	// "**********"
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternFour = function (lineIndex) {
	// "********* "
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 2

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternFive = function (lineIndex) {
	// "*         "
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 10

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternSix = function (lineIndex) {
	// " *********"
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternSeven = function (lineIndex) {
	// "*     ****"
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 5
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternEight = function (lineIndex) {
	// "*   **   *"
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 3
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 3
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternNine = function (lineIndex) {
	// "    **    "
	this.lineCounters[lineIndex] += 4
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 4
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternTen = function (lineIndex) {
	// "     *****"
	this.lineCounters[lineIndex] += 5
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternEleven = function (lineIndex) {
	// "         *"
	this.lineCounters[lineIndex] += 9
	this.pixelsToGlow.push(this.lineCounters[lineIndex])
	++this.lineCounters[lineIndex]

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternTwelve = function (lineIndex) {
	// " *      * "
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 6
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 2

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternThirteen = function (lineIndex) {
	// "  *    *  "
	this.lineCounters[lineIndex] += 1
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 4
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 3

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}

Panel.prototype.patternFourteen = function (lineIndex) {
	// "   *  *   "
	this.lineCounters[lineIndex] += 2
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 2
	this.pixelsToGlow.push(++this.lineCounters[lineIndex])
	this.lineCounters[lineIndex] += 4

	++this.lineCounters[lineIndex]

	return this.pixelsToGlow
}


function startExecution(){

    // Taking no. of panels from the user
    let panelCount = parseInt(prompt(`How many LED panels you want ?`))
    // Few variables
    let text = ''
    let direction = 0
    let panelWidthHidden = 0
    let panelWidthVisible = 0
    let userPanel

    // This counter is for maintaining the last DIV ID displayed on web page
    // GLOBAL VAR
    lastCounter = 0

    // Taking TEXT MESSAGE, DIRECTTION from the user for every panel
    for (let indexPanel = 0; indexPanel < panelCount; indexPanel++) {

        text = prompt(`Enter text message for panel no. ${indexPanel+1}`) + '  '
        direction = parseInt(prompt(`In which direction you want to move the text message for panel no. ${indexPanel+1} ?\n1. Right-Left\n2. Left-Right`))
        
        panelWidthHidden = (text.length * 10) + (text.length - 1)
        panelWidthVisible = 90
        if(panelWidthHidden < panelWidthVisible) panelWidthHidden = panelWidthVisible

        // RIGHT-LEFT
        if(direction === 1){
            userPanel = new Panel(text,panelWidthHidden,panelWidthVisible)
            userPanel.initializePanel()
            userPanel.printLetters()
            setInterval(userPanel.moveLettersLeft,100,[userPanel.pixelsToGlow,userPanel.lineCounterStart,userPanel.lineCounterLimits])
        }
        // LEFT-RIGHT
        else{
            text = text.split(' ').reverse().join(' ')

            userPanel = new Panel(text,panelWidthHidden,panelWidthVisible)
            userPanel.initializePanel()
            userPanel.printLetters()
            setInterval(userPanel.moveLettersRight,100,[userPanel.pixelsToGlow,userPanel.lineCounterStart,userPanel.lineCounterLimits])
        }

    }

}
