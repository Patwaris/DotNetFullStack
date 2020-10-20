import {Component} from '@angular/core';

@Component ({
    selector :'dealer',
    templateUrl :"dealer.component.html"
})

export class DealerComponent
{
    //service (Typescript service)
    //service is consuming web api
    //web api is responsible t fetch the dealer name
    dealerName:string="Amazon";

    isSave:boolean=false;

    imageSrc:string="image src here";

    save(){
        this.dealerName="Walmart";
    }

    users:any=["Bharath","Test1","Test2"];
}