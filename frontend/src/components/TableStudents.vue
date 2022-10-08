<template>
  <v-container>
    <v-data-table :headers="headers" :items="students" :items-per-page="5" class="elevation-3"></v-data-table>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      headers: [
        {
          text: 'Registro Acadêmico',
          align: 'start',
          sortable: false,
          value: 'RA',
        },
        { text: 'Nome', value: 'name' },
        { text: 'CPF', value: 'cpf' },
        { text: 'Ações', value: 'actions' },
      ],
      students: [
        {
          RA: 101123,
          name: 'Paula Souza',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },
        {
          RA: 101124,
          name: 'João Silva',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },
        {
          RA: 101125,
          name: 'Marina Miranda',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },
        {
          RA: 101126,
          name: 'Maurício Souza',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },
        {
          RA: 101127,
          name: 'Carlos Antonio',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },
        {
          RA: 101128,
          name: 'Matheus Chaves',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },
        {
          RA: 101129,
          name: 'Maria Clara',
          cpf: '121.999.999-99',
          actions: 'edit/delete',
        },

      ],
    }
  },
}
</script>
