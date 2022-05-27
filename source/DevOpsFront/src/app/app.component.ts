import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders(
    {
      'Content-Type': 'application/json',
    }
  )
};

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent implements OnInit{
  title = 'Hello DevOps team,';
  weatherList: any[] = [];

  constructor(  private http: HttpClient) 
  { 

     
  }

  ngOnInit(): void {

    this.http.get<any[]>('http://87.106.205.95:4001/WeatherForecast' , httpOptions).subscribe(
      res => {
        this.weatherList = res;
        console.log('helooo',res);
      }
    )
  }

}
