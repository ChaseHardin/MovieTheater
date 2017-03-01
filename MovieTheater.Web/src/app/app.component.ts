import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
  //template: `<h1>Hello {{name}}</h1>`,
    templateUrl: './app/app.component.html'
})
export class AppComponent  { name = 'Angular';

    sumOfTwo(number: number, number2: number) {
        return number + number2;
    }
}
