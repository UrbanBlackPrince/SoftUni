function Person(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;

    Object.defineProperty(this, 'fullName', {
        get() {
            return `${this.firstName} ${this.lastName}`;
        },
        set(arg) {
            let [first, last] = arg.split(' ');
            if (first != undefined && last != undefined) {
                this.firstName = first;
                this.lastName = last;
            }
        },
        enumerable: true,
    })
}
