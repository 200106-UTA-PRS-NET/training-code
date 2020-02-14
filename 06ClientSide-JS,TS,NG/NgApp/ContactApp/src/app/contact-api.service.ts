import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Contact} from './contact/Model/contact';

@Injectable({
  providedIn: 'root'
})
export class ContactApiService {
  url='https://localhost:44342/api/Contact';
  constructor(private httpClient:HttpClient) { }
  getContacts():Promise<Contact[]>{
    return this.httpClient.get<Contact[]>(this.url).toPromise();
  }
}
