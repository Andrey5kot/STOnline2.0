import { Injectable } from '@angular/core';
import {FormBuilder} from "@angular/forms";
import {HttpClient} from "@angular/common/http";
import {GlobalConstants} from "../shared/global-constants";
import {Order} from "../shared/interfaces/interfaces";

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  readonly BaseURL = GlobalConstants.BaseURL;

  constructor(private fb: FormBuilder, private http: HttpClient) { }

  public create(order : Order){
    return this.http.post(this.BaseURL + '/Orders/order', order);
  }

}
