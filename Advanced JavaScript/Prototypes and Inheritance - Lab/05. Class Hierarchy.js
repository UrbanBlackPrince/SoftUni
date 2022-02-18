function geometry(){
    class Figure {
        constructor(units = 'cm') {
            this.units = units;
        }
        get area() { }
        changeUnits(unit) {
            this.units = unit;
        }
        convertUnit(parameter) {
            if (this.units == 'm') {
                return parameter /= 10;
            } else if (this.units == 'mm') {
                return parameter *= 10;
            }
            return parameter;
        }
        toString() {
            return `Figures units: ${this.units}`;
        }
    }
    class Circle extends Figure {
        constructor(radius) {
            super()
            this._radius = radius;
        }
        get area() {
            this.radius = this.convertUnit(this._radius);
            return Math.PI * Math.pow(this.radius, 2);
        }
        toString() {
            return `${super.toString()} Area: ${this.area} - radius: ${this.radius}`;
        }
    }
    class Rectangle extends Figure {
        constructor(width, height, units) {
            super(units)
            this._width = width;
            this._height = height;
        }
        get area() {
            this.width = this.convertUnit(this._width);
            this.height = this.convertUnit(this._height);
            return this.width * this.height;
        }
        toString() {
            return `${super.toString()} Area: ${this.area} - width: ${this.width}, height: ${this.height}`;
        }
    }
    
    return { Figure, Circle, Rectangle };
}

let c = new Circle(5);
console.log(c.area); // 78.53981633974483
console.log(c.toString()); // Figures units: cm Area: 78.53981633974483 - radius: 5
