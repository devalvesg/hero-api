import { Component, OnInit } from '@angular/core';
import { InputTextModule } from 'primeng/inputtext';
import { FloatLabelModule } from 'primeng/floatlabel';
import { FormsModule } from '@angular/forms';
import { DatePickerModule } from 'primeng/datepicker';
import { HeroService } from '../../../shared/services/hero-service';
import { DynamicDialogConfig } from 'primeng/dynamicdialog';

import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

@Component({
  selector: 'app-hero',
  standalone: true,
  imports: [InputTextModule, FloatLabelModule, FormsModule, DatePickerModule, MatDatepickerModule, MatNativeDateModule, MatFormFieldModule, MatInputModule],
  providers: [HeroService],
  templateUrl: './hero.component.html',
  styleUrls: ['./hero.component.scss'],
})
export class HeroComponent implements OnInit {
  entity: any = {};

  constructor(
    private dlgConfig: DynamicDialogConfig,
    private service: HeroService
  ) {}

  ngOnInit(): void {
    if (this.dlgConfig.data) {
      this.service.getHeroById(this.dlgConfig.data.id).subscribe({
        next: (data) => {
          this.entity = data.result
          console.log('this.entity', this.entity)
        },
        error: (error) => {
          console.log(error);
        },
      });
    }
  }
}
