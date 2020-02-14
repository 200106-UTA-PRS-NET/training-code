import { Component, OnInit } from '@angular/core';
import { ContactApiService } from '../contact-api.service';
import {Contact} from './Model/contact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  contacts:Contact[]=null;
  constructor(private contactApiService:ContactApiService) { }
  RecieveContacts():void{
    this.contactApiService.getContacts()
    .then(response=> this.contacts=response);
  }
  ngOnInit(): void {
  }

}
