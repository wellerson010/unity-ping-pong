## Projeto

Jogo clássico **Pong** feito com Unity de acordo com o tutorial [NoobTuts](https://noobtuts.com/unity/2d-pong-game).

## Anotações

* Tudo que deve se mover no mundo Unity, tende a ter um RigidBody.

### Collision Detection

* Discrete - São mais rápidos e mais performáticos, pois a detecção de colisão aqui acontece apenas no **Time.fixedDeltaTime**.

* Continuous - A colisão é detectada de maneira contínua, mesmo que ela ocorre entre dois **FixedUpdate**. Para objetos muito rápidos, esse é recomendado.

### Interpolation

**Interpolate** é usado pra estimar a posição do **RigidBody** entre as atualizações físicas. Pode ser útil mudar isso aqui quando a atualização gráfica é muito mais frequente do que a atualização física, por que, nesse caso, o objeto vai parecer se mover com movimentos bruscos, em vez de movimentos suaves. Com o modo **interpolate**, o movimento é suavizado com base nas posições dos objetos em frames anteriores. Com o modo **extrapolate**, o movimento é suavizado com base em uma estimativa de sua posição no próximo frame.

### Velocity (RigidBody)

É sempre a direção multiplicada pela velocidade.

### GetAxisRaw

Retorna um valor numérico entre -1 e 1, sem filtro de suavização aplicado. Essa falta de filtro é o que a diferencia do **GetAxis**.

### Physics Material 2D

É usado para ajustar a fricção e o **bounce** que ocorre entre materiais físicos 2D quando eles colidem. O **Bounciness** define a rebatida. Zero é nenhuma rebatida. Um é rebatida perfeita sem perda de energia.

### RigidBody.mass

Seguindo a equação clássica de força do Newton:

```
força = massa x aceleração
```

Quanto mais massa um objeto tem, mais força é necessário para acelerá-lo em uma dada velocidade. Também afeta o impulso, que é significante durante colisões, um objeto com mais massa irá se mover menos em uma colisão com um objeto de menor massa.

### Pegar altura simples via colisor

```
collider.bounds.size.y
```

### Vector.normalized

Retorna o vetor com uma magnitude de tamanho 1, mantendo sua direção. O vetor original permanece o mesmo, e um novo vetor é retornado.

A magnitude é o comprimento da linha formada entre (0, 0, 0) e o ponto no espaço. Normalizando, você garante que sua magnite seja um. Ex:

Vector3(0, 0, 5) representa uma direção de 5 unidades no eixo Z, tendo então ele um tamanho 5. Se você o normaliza, ele se torna um Vector3(0, 0, 1). Você só pode usá-lo se a única coisa que importa pra você é a direção, e não o tamanho.