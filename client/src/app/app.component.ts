import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title:string = 'dating app client';
  users:any;
  constructor(private http:HttpClient){

  }

  ngOnInit():void{
    // http://localhost:4200/
    // https://localhost:7272/api/users
    this.http.get('https://localhost:7272/api/users').subscribe({
    next:(response)=>this.users=response,
    error:(e)=>console.log(e),
    complete:()=>console.log("request has completed ")
    });
  }

}
