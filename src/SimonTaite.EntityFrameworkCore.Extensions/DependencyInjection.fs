namespace SimonTaite.EntityFrameworkCore.Extensions

open System
open Microsoft.EntityFrameworkCore
open Microsoft.Extensions.DependencyInjection

module DependencyInjection =

    let addDbContext<'a when 'a :> DbContext> (optionsAction: Option<Action<DbContextOptionsBuilder>>) contextLifetime optionsLifetime serviceCollection =

        let optionsAction' =
            match optionsAction with
            | Some x -> x
            | None -> null

        let contextLifetime' =
            match contextLifetime with
            | Some c -> c
            | None -> ServiceLifetime.Scoped

        let optionsLifetime' =
            match optionsLifetime with
            | Some c -> c
            | None -> ServiceLifetime.Scoped

        EntityFrameworkServiceCollectionExtensions.AddDbContext<'a>(serviceCollection, optionsAction', contextLifetime', optionsLifetime')

    let addDbContext2<'a when 'a :> DbContext> (optionsAction: Option<Action<IServiceProvider, DbContextOptionsBuilder>>) contextLifetime optionsLifetime serviceCollection =

        let optionsAction' =
            match optionsAction with
            | Some x -> x
            | None -> null

        let contextLifetime' =
            match contextLifetime with
            | Some c -> c
            | None -> ServiceLifetime.Scoped

        let optionsLifetime' =
            match optionsLifetime with
            | Some c -> c
            | None -> ServiceLifetime.Scoped

        EntityFrameworkServiceCollectionExtensions.AddDbContext<'a>(serviceCollection, optionsAction', contextLifetime', optionsLifetime')

    let addDbContextPool<'a when 'a :> DbContext> (optionsAction: Action<DbContextOptionsBuilder>) poolSize serviceCollection =
        EntityFrameworkServiceCollectionExtensions.AddDbContextPool<'a>(serviceCollection, optionsAction, poolSize)

    let addDbContextPool2<'a when 'a :> DbContext>(optionsAction: Action<IServiceProvider, DbContextOptionsBuilder>) poolSize serviceCollection =
        EntityFrameworkServiceCollectionExtensions.AddDbContextPool<'a>(serviceCollection, optionsAction, poolSize)

    let addEntityFrameworkStores<'a when 'a :> DbContext> builder =
        IdentityEntityFrameworkBuilderExtensions.AddEntityFrameworkStores<'a> builder
