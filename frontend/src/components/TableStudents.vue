<!-- eslint-disable vue/valid-v-slot -->
<template>
  <v-data-table :headers="headers" :items="students" sort-by="name" class="elevation-1">
    <template v-slot:top>
      <v-toolbar flat>
        <v-toolbar-title>Lista de Alunos</v-toolbar-title>
        <v-divider class="mx-4" inset vertical></v-divider>
        <v-spacer></v-spacer>
        <v-dialog v-model="dialog" max-width="500px">
          <template v-slot:activator="{ on, attrs }">
            <v-btn color="primary" dark class="mb-2" v-bind="attrs" v-on="on">
              Adicionar novo registro
            </v-btn>
          </template>
          <v-card>
            <v-card-title>
              <span class="text-h5">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>
              <v-container>
                <v-row>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.name" label="Nome do aluno"
                      :rules="[() => !!name || 'Campo obrigatório']" :error-messages="errorMessages">
                    </v-text-field>
                  </v-col>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.email" label="E-mail"
                      :rules="[() => !!email || 'Campo obrigatório']" :error-messages="errorMessages"></v-text-field>
                  </v-col>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.cpf" label="CPF" :rules="[() => !!cpf || 'Campo obrigatório']"
                      :error-messages="errorMessages"></v-text-field>
                  </v-col>
                </v-row>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="close">
                Cancelar
              </v-btn>
              <v-btn color="blue darken-1" text @click="save">
                Salvar
              </v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
        <v-dialog v-model="dialogDelete" max-width="500px">
          <v-card>
            <v-card-title class="text-h6">Você tem certeza que quer excluir esse item?</v-card-title>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="closeDelete">Não, quero voltar!</v-btn>
              <v-btn color="blue darken-1" text @click="deleteItemConfirm">Sim, exclua esse item!</v-btn>
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
    </template>
    <template v-slot:item.actions="{ item }">
      <v-icon small class="mr-2" @click="editItem(item)">
        mdi-pencil
      </v-icon>
      <v-icon small @click="deleteItem(item)">
        mdi-delete
      </v-icon>
    </template>
    <template v-slot:no-data>
      <v-btn color="primary" @click="initialize">
        Reset
      </v-btn>
    </template>
  </v-data-table>
</template>

<script>
export default {
  data: () => ({
    dialog: false,
    dialogDelete: false,
    headers: [
      {
        text: 'Registro Acadêmico',
        align: 'start',
        sortable: true,
        value: 'RA',
      },
      { text: 'Nome', value: 'name' },
      { text: 'E-mail', value: 'email' },
      { text: 'CPF', value: 'cpf' },
      { text: 'Ações', value: 'actions' },
    ],
    students: [],
    editedIndex: -1,
    editedItem: {
      name: '',
      email: '',
      cpf: '',
    },
    defaultItem: {
      name: '',
      cpf: '',
    },
  }),

  computed: {
    formTitle() {
      return this.editedIndex === -1 ? 'Novo Registro' : 'Editar Registro'
    },
  },

  watch: {
    dialog(val) {
      val || this.close()
    },
    dialogDelete(val) {
      val || this.closeDelete()
    },
  },

  created() {
    this.initialize()
  },

  methods: {
    initialize() {
      this.students = [
        {
          RA: 101123,
          name: 'Paula Souza',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
        {
          RA: 101124,
          name: 'João Silva',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
        {
          RA: 101125,
          name: 'Marina Miranda',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
        {
          RA: 101126,
          name: 'Maurício Souza',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
        {
          RA: 101127,
          name: 'Carlos Antonio',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
        {
          RA: 101128,
          name: 'Matheus Chaves',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
        {
          RA: 101129,
          name: 'Maria Clara',
          cpf: '121.999.999-99',
          email: 'email@email.com',
          actions: 'edit/delete',
        },
      ]
    },

    editItem(item) {
      console.log('passei')
      console.log('editando item', item)
      this.editedIndex = this.students.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.dialog = true
    },

    deleteItem(item) {
      console.log('deletando item', item)
      this.editedIndex = this.students.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.dialogDelete = true
    },

    deleteItemConfirm() {
      console.log('confirmei que deletei')
      this.students.splice(this.editedIndex, 1)
      this.closeDelete()
    },

    close() {
      console.log('fechar')
      this.dialog = false
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      })
    },

    closeDelete() {
      console.log('fechar delete')
      this.dialogDelete = false
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      })
    },

    save() {
      if (this.editedItem.name === '' || this.editedItem.email === '' || this.editedItem.cpf === '') {
        return console.log('campos vazios')
      }

      if (this.editedIndex > -1) {
        Object.assign(this.students[this.editedIndex], this.editedItem)
      } else {
        this.students.push(this.editedItem)
      }
      this.close()
    },
  },
}
</script>