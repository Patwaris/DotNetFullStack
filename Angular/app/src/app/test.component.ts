import {Component} from '@angular/core';

@Component(
    {
        selector:'test',
        template:'<h1>My Test Angular {{version}} </h1>'
    }
)

export class TestComponent{
    version =7;
}