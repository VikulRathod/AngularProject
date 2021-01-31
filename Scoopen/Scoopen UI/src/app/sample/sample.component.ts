import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sample',
  templateUrl: './sample.component.html',
  styleUrls: ['./sample.component.css']
})
export class SampleComponent implements OnInit {

  userName: string = 'Vishal';

  constructor() { }

  ngOnInit(): void {
  }

  add(a : number, b : number): number {
    return a + b;
  }

}
