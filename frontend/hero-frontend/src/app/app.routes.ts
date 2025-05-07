import { Routes } from '@angular/router';

export const routes: Routes = [  {
    path: '',
    loadComponent: () =>
      import('./pages/home/home.component').then(m => m.HomeComponent)
  },
  {
    path: 'hero/index',
    loadComponent: () =>
      import('./pages/heroes/index/hero.index.component').then(m => m.HeroIndexComponent)
  },
  {
    path: 'hero',
    loadComponent: () =>
      import('./pages/heroes/hero/hero.component').then(m => m.HeroComponent)
  }];
