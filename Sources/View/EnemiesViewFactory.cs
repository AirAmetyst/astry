using Asteroids.Model;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesViewFactory : TransformableViewFactory<Enemy>
{
    [SerializeField] private TransformableView _asteroid;
    [SerializeField] private TransformableView _partOfAsteroid;
    [SerializeField] private TransformableView _nlo;
    [SerializeField] private TransformableView _secondEnemy;


    protected override TransformableView GetTemplate(Enemy enemy)
    {
        if (enemy is PartOfAsteroid)
            return _partOfAsteroid;
        else if (enemy is Asteroid)
            return _asteroid;
        else if (enemy is Nlo)
            return _nlo;
        else if (enemy is SecondEnemy)
            return _secondEnemy;

        throw new InvalidOperationException();
    }
}
