import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../../../environments/environment";

@Injectable({
    providedIn: 'root' 
})
export class HeroService {
  constructor(private http: HttpClient) {
  }

  path: any = environment.baseUrl;

  getHeroes(): Observable<any> {
    return this.http.get(`${this.path}/hero`);
  }

  getHeroById(id: number): Observable<any> {
    return this.http.get(`${this.path}/hero/${id}`);
  }
}
