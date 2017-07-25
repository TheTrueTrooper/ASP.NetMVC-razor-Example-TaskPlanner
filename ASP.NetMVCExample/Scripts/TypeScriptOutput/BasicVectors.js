"use strict";
var Vector2D = (function () {
    //Constructs a 2D vector X is the horizontal location Y is the Vertical location
    function Vector2D(X, Y) {
        this.X = X;
        this.Y = Y;
    }
    //This funtion Creates a vector with the added vectors from the value being called from and passed and return it for resighning or chaining
    Vector2D.prototype.Add = function (Vector) {
        var Return = new Vector2D(this.X, this.Y);
        Return.X += Vector.X;
        Return.Y += Vector.Y;
        return Return;
    };
    //This funtion Creates a vector with the subtracted vectors from the value being called from and passed and return it for resighning or chaining
    Vector2D.prototype.Sub = function (Vector) {
        var Return = new Vector2D(this.X, this.Y);
        Return.X -= Vector.X;
        Return.Y -= Vector.Y;
        return Return;
    };
    //This funtion Creates a vector with the scaled vector from the value being used and passed and return it for resighning or chaining
    Vector2D.prototype.Scale = function (Number) {
        var Return = new Vector2D(this.X, this.Y);
        Return.X *= Number;
        Return.Y *= Number;
        return Return;
    };
    //simply displays the value of the vector as a comma seperated string and a space on the end
    Vector2D.prototype.ToString = function () {
        return this.X.toString() + "," + this.Y.toString() + " ";
    };
    return Vector2D;
}());
exports.Vector2D = Vector2D;
//# sourceMappingURL=BasicVectors.js.map