function Vehicle() {

    this.speed = 0;
    this.propulsionUnits = [];
}

Vehicle.prototype.addPropulsionUnit = function(unit){
    this.propulsionUnits.push(unit);
}

Vehicle.prototype.accelerate = function(){
    for(var i = 0; i < this.propulsionUnits.length; i++ ) {
        this.speed += this.propulsionUnits[i].acceleration;
    }
    //console.log here for easyer testing
    console.log("After aceleration the speed is:" + this.speed);
}

function PropulsionUnit() {
    this.acceleration;
}

function Wheel(radius) {
    PropulsionUnit.call(this);

    this.radius = radius;

    this.acceleration = (2 * Math.PI * radius);
}
Wheel.prototype = Object.create(PropulsionUnit.prototype);

function PropellingNozzle(power, afterburnerTurnedOn){
    PropulsionUnit.call(this);

    this.power = power;
    this.afterburner = afterburnerTurnedOn;

    if(this.afterburner){
        this.acceleration = 2 * this.power;
    }
    else {
        this.acceleration = this.power;
    }
}
PropellingNozzle.prototype = Object.create(PropulsionUnit.prototype);

function Propeller(finsNumber, spinDirection){
    PropulsionUnit.call(this);

    this.finsNumber = finsNumber;
    this.spinDirection = spinDirection;
    
    if(spinDirection == "clockwise")
    {
        this.acceleration = this.finsNumber;
    } 
    else {
        this.acceleration = (-1 * this.finsNumber);
    }
}
Propeller.prototype = Object.create(PropulsionUnit.prototype);

//Vehicles
function LandVehicle(wheel1 , wheel2, wheel3, wheel4) {
    Vehicle.call(this);

    this.propulsionUnits.push(wheel1);
    this.propulsionUnits.push(wheel2);
    this.propulsionUnits.push(wheel3);
    this.propulsionUnits.push(wheel4);
}
LandVehicle.prototype = Object.create(Vehicle.prototype);

function AirVehicle(PropellingNozzle) {
    Vehicle.call(this);

    this.propulsionUnits.push(PropellingNozzle);
}
AirVehicle.prototype = Object.create(Vehicle.prototype);

AirVehicle.prototype.turnAfterburnerOn = function(trueOrFalse){
    this.propulsionUnits[0].afterburner = trueOrFalse;
}

function WaterVehicles(propellers) {
    Vehicle.call(this);

    this.propulsionUnits.push(propellers);
}
WaterVehicles.prototype = Object.create(Vehicle.prototype);

WaterVehicles.prototype.setPropellersDirection = function(direction){
    this.propulsionUnits[0].spinDirection = direction;
    this.propulsionUnits[0].acceleration *= -1;
}

function AmphibiousVehicle(mode, wheel1 , wheel2, wheel3, wheel4, propellers) {
    Vehicle.call(this);

    this.propulsionUnits.push(propellers);

    if(mode == 'land') {
        LandVehicle.call(this, wheel1 , wheel2, wheel3, wheel4);
    }
    else {
        WaterVehicles.call(this, propellers);
    }
}
AmphibiousVehicle.prototype = Object.create(Vehicle.prototype);