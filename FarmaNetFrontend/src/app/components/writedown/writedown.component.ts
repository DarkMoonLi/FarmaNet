import { Component, Input, OnInit } from '@angular/core';
import { WritedownDto } from 'src/app/dto/writedown.dto';

@Component({
  selector: 'app-writedown',
  templateUrl: './writedown.component.html',
  styleUrls: ['./writedown.component.scss']
})
export class WritedownComponent implements OnInit {

  @Input() 
  writedown!: WritedownDto;
  
  constructor() { }

  ngOnInit(): void {
  }

}
