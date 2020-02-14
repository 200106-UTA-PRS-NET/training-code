import { Component } from '@angular/core';

@Component({
    selector:'test',
    template:`
    <h1>Test component works</h1>
    <strong>Contact Name </strong>{{contact}}
    `
})
export class TestComponent{
    contact="Pushpinder Kaur"
}