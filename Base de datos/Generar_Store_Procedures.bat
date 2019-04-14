@echo off
type SP_EliminarTodos.sql > SP_Unificado.sql
type Store_Procedures\*.sql >> SP_Unificado.sql
type Vistas\*.sql >> SP_Unificado.sql