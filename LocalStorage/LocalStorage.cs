﻿using Microsoft.JSInterop;
using Reto2G5.Enum;
using Reto2G5.Helpers;
using Reto2G5.Interfaces;
using Reto2G5.LocalStorage;


using System.Text.Json;
using System.Web.Http.Results;

namespace Reto2G5.LocalStorage
{
    public class LocalStorage : ILocalStorage
    {
        public LocalStorage(IJSRuntime jSRuntime)
        {
            this.JSRuntime = jSRuntime;
        }


        private readonly IJSRuntime JSRuntime;

        private readonly string tipoDeAlmacenamiento = "sessionStorage.";
        public async Task ClearAll()
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}clear").ConfigureAwait(false);
            
        }

        public async Task<T> GetValue<T>(ValuesKeys key)
        {
            string data = await JSRuntime.InvokeAsync<string>($"{tipoDeAlmacenamiento}getItem",
                                                                  key.ToString()).ConfigureAwait(false);

            return IsDataNull.Check<T>(data);

        }

        public async Task RemoveItem(ValuesKeys key)
        {
           await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}removeItem", key.ToString()).ConfigureAwait(false);
        }

        public async Task SetValue<T>(ValuesKeys key, T value)
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}setItem", key.ToString(), JsonSerializer.Serialize(value)).ConfigureAwait(false);
        }
    }
}
