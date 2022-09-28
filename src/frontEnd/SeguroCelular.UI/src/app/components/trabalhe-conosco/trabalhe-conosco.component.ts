import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-trabalhe-conosco',
  templateUrl: './trabalhe-conosco.component.html',
  styleUrls: ['./trabalhe-conosco.component.css']
})
export class TrabalheConoscoComponent implements OnInit {

  cadastroForm!: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
  }

}
