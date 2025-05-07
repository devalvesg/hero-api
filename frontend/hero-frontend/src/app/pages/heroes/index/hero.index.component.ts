import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DialogService, DynamicDialogModule } from 'primeng/dynamicdialog';
import { HeroComponent } from '../hero/hero.component';
import { HeroService } from '../../../shared/services/hero-service';

@Component({
  selector: 'app-hero.index',
  imports: [CommonModule, DynamicDialogModule],
  providers: [DialogService, HeroService],
  templateUrl: './hero.index.component.html',
  styleUrl: './hero.index.component.scss',
})
export class HeroIndexComponent implements OnInit {
  constructor(private dialogService: DialogService, private service: HeroService) {}

  heroes: any[] = [];

  ngOnInit(): void {
    this.service.getHeroes().subscribe({
      next: (data: any) => {
        console.log('data', data)
        this.heroes = data.result;
      },
      error: (error: any) => {
        
      }
    })
  }

  onEdit(hero: any) {
    this.dialogService.open(HeroComponent, {
      header: 'Editar Herói',
      width: '35%',
      height: '55%',
      modal: true,
      data: {id: hero.id},
      styleClass: 'modal',
      contentStyle: { overflow: 'auto' },
      baseZIndex: 10000,
      closable: true,
    });
  }

  onDelete(hero: any) {}

  addHero() {
    this.dialogService.open(HeroComponent, {
      header: 'Criar Herói',
      width: '35%',
      height: '55%',
      modal: true,
      styleClass: 'modal',
      contentStyle: { overflow: 'auto' },
      baseZIndex: 10000,
      closable: true,
    });
  }
}
